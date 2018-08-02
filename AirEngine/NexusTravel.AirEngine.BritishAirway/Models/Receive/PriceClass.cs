using System.Collections.Generic;
using System.Xml.Serialization;

namespace NexusTravel.AirEngine.BritishAirway.Models.Receive
{
    public class PriceClass
    {
        [XmlAttribute]
        public string ObjectKey { get; set; }

        public string Name { get; set; }
        public List<Description> Descriptions { get; set; }
    }
}
