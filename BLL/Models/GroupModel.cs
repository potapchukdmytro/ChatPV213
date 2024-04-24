using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class GroupModel
    {
        public string Name { get; set; }
        public int UserId { get; set; }
        public int ChatId { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
