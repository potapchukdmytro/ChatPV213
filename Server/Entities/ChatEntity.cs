using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Entities
{
    public class ChatEntity : BaseEntity
    {
        public required string Title { get; set; }
        public virtual List<UserEntity> Users { get; set; } = new();
        public virtual List<MessageEntity> Messages { get; set; } = new();
    }
}
