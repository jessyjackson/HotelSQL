using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DbEntities
{
    internal class Reservation
    {
        public int ID { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public int ClientID { get; set; }
        public string TratamentType { get; set; }
        public bool Deleted { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
