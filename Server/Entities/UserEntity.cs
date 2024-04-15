using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Entities
{
    public class UserEntity : BaseEntity
    {
        public required string Email { get; set; }
        public required string Password { get; set; }
        public required string UserName { get; set; }
        public DateTime Birthday { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public virtual List<ChatEntity> Chats { get; set; } = new();
        public virtual List<MessageEntity> Messages { get; set; } = new();
    }
}
