using Client;
using Client.Models;
using System;
using System.Linq;
using System.Threading.Tasks;
using Azure;
using BLL.Models;
using Server.Entities;
using Server.Repositories;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

namespace Server.Services
{
    public class UserService
    {
        private readonly UserRepository _userRepository;
        private readonly Mapper _mapper;

        public UserService(UserRepository userRepository, Mapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
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
            return _userRepository.Users.FirstOrDefault(u => u.Id == userId);
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

        public async Task<bool> IsUserNameUniqueAsync(string userName)
        {
            return await _userRepository.Users.AnyAsync(u => u.UserName == userName);
        }

        public async Task<bool> IsEmailUniqueAsync(string email)
        {
            return await _userRepository.Users.AnyAsync(u => u.Email == email);
        }

        public async Task<ServiceResponse> SignUpAsync(SignUpModel signUpModel)
        {
            var response = new ServiceResponse();

            try
            {
                if (!await IsUserNameUniqueAsync(signUpModel.Username))
                {
                    response.IsSuccess = false;
                    response.Message = "Користувач з таким username вже існує.";
                    return response;
                }

                if (!await IsEmailUniqueAsync(signUpModel.Email))
                {
                    response.IsSuccess = false;
                    response.Message = "Користувач з таким email вже існує.";
                    return response;
                }

                var newUser = new UserEntity
                {
                    FirstName = signUpModel.Name,
                    LastName = signUpModel.Lastname,
                    UserName = signUpModel.Username,
                    Email = signUpModel.Email,
                    Password = signUpModel.Password
                };

                var createUserResponse = await CreateUserAsync(newUser);
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ex.Message;
            }

            return response;
        }

        public async Task<UserModel?> SignInAsync(LogInModel signInModel)
        {
            try
            {
                var user = await _userRepository.Users.FirstOrDefaultAsync(u =>
                    u.UserName == signInModel.Login || u.Email == signInModel.Login);

                if (user == null)
                {
                    return null;
                }

                if (user.Password != signInModel.Password)
                {
                    return null;
                }

                var entity = await GetUserByIdAsync(user.Id);

                var userModel = _mapper.Map<UserModel>(entity);

                return userModel;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
