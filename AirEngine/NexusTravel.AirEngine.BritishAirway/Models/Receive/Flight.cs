using System.Xml.Serialization;

namespace NexusTravel.AirEngine.BritishAirway.Models.Receive
{
    public class Flight
    {
        [XmlAttribute]
        public string FlightKey { get; set; }

        public Journey Journey { get; set; }
        public string SegmentReferences { get; set; }
    }
}
