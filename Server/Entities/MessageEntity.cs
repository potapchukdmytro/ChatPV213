using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Entities
{
    public class MessageEntity : BaseEntity
    {
        public string Text { get; set; } = string.Empty;
        [ForeignKey("User")]
        public int UserId { get; set; }
        [ForeignKey("Chat")]
        public int ChatId { get; set; }
        public UserEntity? User { get; set; }
        public ChatEntity? Chat { get; set; }
    }
}
