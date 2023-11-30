using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DbEntities
{
    internal class Treatment
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public bool Deleted { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
