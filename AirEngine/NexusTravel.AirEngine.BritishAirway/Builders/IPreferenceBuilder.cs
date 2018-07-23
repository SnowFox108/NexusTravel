using NexusTravel.AirEngine.BritishAirway.Models;
using NexusTravel.AirEngine.BritishAirway.Models.Common;

namespace NexusTravel.AirEngine.BritishAirway.Builders
{
    public interface IPreferenceBuilder
    {
        Preference Create(FlightSearch search);
    }
}
