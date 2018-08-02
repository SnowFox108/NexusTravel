using System.Collections.Generic;
using NexusTravel.AirEngine.BritishAirway.Models.Common;

namespace NexusTravel.AirEngine.BritishAirway.Models.Receive
{
    public class DataLists
    {
        public List<AnonymousTraveler> AnonymousTravelerList { get; set; }
        public List<Disclosures> DisclosureList { get; set; }
        public List<FareGroup> FareList { get; set; }
        public List<FlightSegment> FlightSegmentList { get; set; }
        public List<Flight> FlightList { get; set; }
        public List<OriginDestination> OriginDestinationList { get; set; }
        public List<PriceClass> PriceClassList { get; set; }
    }
}
