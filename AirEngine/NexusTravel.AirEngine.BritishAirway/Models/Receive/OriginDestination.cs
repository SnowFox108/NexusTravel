using System.Xml.Serialization;

namespace NexusTravel.AirEngine.BritishAirway.Models.Receive
{
    public class OriginDestination
    {
        [XmlAttribute]
        public string OriginDestinationKey { get; set; }

        public string DepartureCode { get; set; }
        public string ArrivalCode { get; set; }
        public string FlightReferences { get; set; }
    }
}
