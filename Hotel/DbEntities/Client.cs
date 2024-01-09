using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DbEntities
{
    internal class Client
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ?Mail { get; set; }
        public bool Deleted { get; set; }
        [Browsable(false)] public DateTime CreatedAt { get; set; }
        public override string ToString()
        {
            return Name;
        }

    }
}
