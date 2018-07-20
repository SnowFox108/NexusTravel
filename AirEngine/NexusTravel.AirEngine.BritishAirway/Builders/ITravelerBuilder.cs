using System.Collections.Generic;
using NexusTravel.AirEngine.BritishAirway.Models;
using NexusTravel.AirEngine.BritishAirway.Models.Common;

namespace NexusTravel.AirEngine.BritishAirway.Builders
{
    internal interface ITravelerBuilder
    {
        List<Traveler> Create(FlightSearch search);
    }
}
