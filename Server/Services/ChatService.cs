using Server.Entities;
using Server.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Services
{
    public class ChatService
    {
        private readonly ChatRepository _chatRepository;

        public ChatService(ChatRepository chatRepository)
        {
            _chatRepository = chatRepository;
        }

        public async Task<ServiceResponse> CreateChatAsync(ChatEntity chat)
        {
            var response = new ServiceResponse();
            try
            {
                await _chatRepository.AddAsync(chat);
                response.IsSuccess = true;
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ex.Message;
            }
            return response;
        }

        public async Task<ChatEntity?> GetChatByIdAsync(int chatId)
        {
            return await _chatRepository.GetByIdAsync(chatId);
        }

        public async Task<ServiceResponse> UpdateChatAsync(ChatEntity chat)
        {
            var response = new ServiceResponse();
            try
            {
                await _chatRepository.UpdateAsync(chat);
                response.IsSuccess = true;
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ex.Message;
            }
            return response;
        }

        public async Task<ServiceResponse> DeleteChatAsync(ChatEntity chat)
        {
            var response = new ServiceResponse();
            try
            {
                await _chatRepository.RemoveAsync(chat);
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
