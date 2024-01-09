using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DbEntities
{
    internal class Room
    {
        public int Number { get; set; }
        public int MaxPeople { get; set; }
        public int TypeId { get; set; }
        public bool Deleted { get; set; }
        public DateTime CreatedAt { get; set; }

        public override bool Equals(object ?obj)
        {
            return obj != null && obj is Room room && room.Number == Number;
        }
        public override int GetHashCode()
        {
            return Number.GetHashCode();
        }
        public override string ToString()
        {
            return "Room number: " + Number.ToString() +" \n" + "Max People: " + MaxPeople;
        }
    }
}
