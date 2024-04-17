using Microsoft.EntityFrameworkCore;
using Server.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Repositories
{
    public class MessageRepository : GenericRepository<MessageEntity>
    {
        public MessageRepository(AppDbContext context) : base(context)
        {
        }

        public IQueryable<MessageEntity> Messages
        {
            get
            {
                return GetAll().Include(m => m.User).Include(m => m.Chat);
            }
        }
    }
}
