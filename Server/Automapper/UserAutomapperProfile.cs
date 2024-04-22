using AutoMapper;
using BLL.Models;
using Server.Entities;

namespace Server.Automapper
{
    public class UserAutomapperProfile : Profile
    {
        public UserAutomapperProfile()
        {
            CreateMap<UserEntity, UserModel>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.FirstName))
                .ForMember(dest => dest.Chats, opt => opt.MapFrom(src => src.Chats.Select(c => c.Id)))
                .ForMember(dest => dest.Messages, opt => opt.MapFrom(src => src.Messages.Select(m => m.Id)));
        }
    }
}
