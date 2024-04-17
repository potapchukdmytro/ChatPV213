using Server.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Server.ServerClasses
{
    public class ClientModel
    {
        public required UserEntity User { get; set; }
        public required IPEndPoint EndPoint { get; set; }
    }
}
