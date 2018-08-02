using System.Collections.Generic;
using System.Xml.Serialization;

namespace NexusTravel.AirEngine.BritishAirway.Models.Receive
{
    public class Disclosures
    {
        [XmlAttribute]
        public string ListKey { get; set; }
        [XmlElement("Description")]
        public List<Description> Descriptions { get; set; }
    }
}
