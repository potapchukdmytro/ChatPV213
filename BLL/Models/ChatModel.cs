using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class ChatModel
    {
        public string Title { get; set; }
        public virtual List<UserModel> Users { get; set; } = new();
        public virtual List<MessageModel> Messages { get; set; } = new();
    }
}
