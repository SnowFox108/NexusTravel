using System.Xml.Serialization;

namespace NexusTravel.AirEngine.BritishAirway.Models.Receive
{
    public class FareGroup
    {
        [XmlAttribute]
        public string ListKey { get; set; }

        public Fare Fare { get; set; }
        public FareCode FareBasisCode { get; set; }
    }
}
