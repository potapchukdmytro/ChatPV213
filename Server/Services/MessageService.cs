using BLL.Models;
using Server.Entities;
using Server.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Services
{
    public class MessageService
    {
        private readonly MessageRepository _messageRepository;
        private readonly UserService userService;
        public MessageService(MessageRepository messageRepository, UserService userService)
        {
            _messageRepository = messageRepository;
            this.userService = userService;
        }

        public async Task<ServiceResponse> CreateMessageAsync(MessageEntity message)
        {
            var response = new ServiceResponse();
            try
            {
                await _messageRepository.AddAsync(message);
                response.IsSuccess = true;
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ex.Message;
            }
            return response;
        }

        public async Task<ServiceResponse> CreateMessageAsync(SendMessageModel model)
        {
            MessageEntity entity = new MessageEntity
            {
                Text = model.Text,
                ChatId = model.ChatId,
                UserId = model.UserId,
                CreatedDate = DateTime.UtcNow,
                IsDeleted = false
            };

            return await CreateMessageAsync(entity);
        }

        public async Task<List<MessageModel>> GetMessagesByUserAsync(int id)
        {
            var user = await userService.GetUserByIdAsync(id);

            if(user != null)
            {
                var res = user.Messages.Select(m =>
                {
                    return new MessageModel
                    {
                        ChatId = m.ChatId,
                        Text = m.Text,
                        UserId = m.UserId
                    };
                });

                return res.ToList();
            }

            return new List<MessageModel>();
        }

        public async Task<MessageEntity?> GetMessageByIdAsync(int messageId)
        {
            return await _messageRepository.GetByIdAsync(messageId);
        }

        public async Task<ServiceResponse> UpdateMessageAsync(MessageEntity message)
        {
            var response = new ServiceResponse();
            try
            {
                await _messageRepository.UpdateAsync(message);
                response.IsSuccess = true;
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ex.Message;
            }
            return response;
        }

        public async Task<ServiceResponse> DeleteMessageAsync(MessageEntity message)
        {
            var response = new ServiceResponse();
            try
            {
                await _messageRepository.RemoveAsync(message);
                response.IsSuccess = true;
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ex.Message;
            }
            return response;
        }
    }
}
