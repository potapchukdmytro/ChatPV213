using Microsoft.EntityFrameworkCore;
using Server.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Repositories
{
    public class UserRepository : GenericRepository<UserEntity>
    {
        public UserRepository(AppDbContext context) : base(context)
        {
        }

        public IQueryable<UserEntity> Users 
        { 
            get
            {
                return GetAll().Include(u => u.Messages).Include(u => u.Chats);
            } 
        }
    }
}
