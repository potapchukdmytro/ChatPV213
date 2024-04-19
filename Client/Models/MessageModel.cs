using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Models
{
    public class MessageModel
    {
        public string Text { get; set; }
        public int UserId { get; set; }
        public int ChatId { get; set; }
        public UserModel User { get; set; }
        public ChatModel Chat { get; set; }
    }
}
