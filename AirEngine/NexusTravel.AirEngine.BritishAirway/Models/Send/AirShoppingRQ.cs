﻿using System.Collections.Generic;
using System.Xml.Serialization;
using ClientTest.Entities;
using NexusTravel.AirEngine.BritishAirway.Models.Common;

namespace NexusTravel.AirEngine.BritishAirway.Models.Send
{
    internal class AirShoppingRQ
    {

        [XmlAttribute]
        public string Version { get; set; }

        internal Document Document { get; set; }
        internal Party Party { get; set; }
        public List<Traveler> Travelers { get; set; }
        public CoreQuery CoreQuery { get; set; }
        public Preference Preference { get; set; }

        public AirShoppingRQ()
        {
            Version = "16.1";
        }

    }
}
