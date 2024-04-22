using AutoMapper;
using BLL.Models;
using Server.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Automapper
{
    public class MessageAutomapperProfile : Profile
    {
        public MessageAutomapperProfile()
        {
            CreateMap<MessageEntity, MessageModel>();
        }
    }
}
