using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DbEntities
{
    internal class Room
    {
        public int ID { get; set; }
        public int MaxPeople { get; set; }
        public int TypeId { get; set; }
    }
}
