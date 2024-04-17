using Microsoft.EntityFrameworkCore;
using Server.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Repositories
{
    public class ChatRepository : GenericRepository<ChatEntity>
    {
        public ChatRepository(AppDbContext context) : base(context)
        {
        }

        public IQueryable<ChatEntity> Chats
        {
            get
            {
                return GetAll().Include(c => c.Users).Include(c => c.Messages);
            }
        }
    }
}
