using System.Xml.Serialization;
using NexusTravel.AirEngine.BritishAirway.Models.Common;

namespace NexusTravel.AirEngine.BritishAirway.Models.Receive
{
    public class FlightSegment
    {
        [XmlAttribute]
        public string SegmentKey { get; set; }
        public Departure Departure { get; set; }
        public Arrival Arrival { get; set; }
        public MarketingCarrier MarketingCarrier { get; set; }
        public OperatingCarrier OperatingCarrier { get; set; }
        public Equipment Equipment { get; set; }
        public FlightDetail FlightDetail { get; set; }
    }
}
