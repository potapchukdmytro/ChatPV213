using System;
using System.Linq;
using System.Threading.Tasks;
using Azure;
using Server.Entities;
using Server.Repositories;

namespace Server.Services
{
    public class UserService
    {
        private readonly UserRepository _userRepository;

        public UserService(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<ServiceResponse> CreateUserAsync(UserEntity user)
        {
            var response = new ServiceResponse();
            try
            {
                await _userRepository.AddAsync(user);
                response.IsSuccess = true;
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ex.Message;
            }
            return response;
        }

        public async Task<UserEntity?> GetUserByIdAsync(int userId)
        {
            return await _userRepository.GetByIdAsync(userId);
        }

        public async Task<ServiceResponse> UpdateUserAsync(UserEntity user)
        {
            var response = new ServiceResponse();
            try
            {
                await _userRepository.UpdateAsync(user);
                response.IsSuccess = true;
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ex.Message;
            }
            return response;
        }

        public async Task<ServiceResponse> DeleteUserAsync(UserEntity user)
        {
            var response = new ServiceResponse();
            try
            {
                await _userRepository.RemoveAsync(user);
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
