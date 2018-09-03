using System;
using System.Collections.Generic;
using System.Text;

namespace EventSourcing.Models
{
    public class Ship
    {
        public int ShipId { get; set; }

        public string Name { get; set; }

        public Port CurrentLocation { get; set; }
    }
}
