using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Entities
{
    public interface IBaseEntity 
    {
        public int Id { get; set; }
    }

    internal class BaseEntity : IBaseEntity
    {
        public int Id { get; set; }

    }
}
