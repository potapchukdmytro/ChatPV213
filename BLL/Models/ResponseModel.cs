using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class ResponseModel
    {
        public bool IsSucces { get; set; }
        public required string Message { get; set; }
    }
}
