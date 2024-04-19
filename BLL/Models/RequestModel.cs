using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class RequestModel
    {
        public required string Method { get; set; }
        public required string Data { get; set; }
    }
}
