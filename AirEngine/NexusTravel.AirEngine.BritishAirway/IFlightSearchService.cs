using NexusTravel.AirEngine.BritishAirway.Models;
using NexusTravel.AirEngine.BritishAirway.Models.Receive;

namespace NexusTravel.AirEngine.BritishAirway
{
    public interface IFlightSearchService
    {
        AirShoppingRS Search(FlightSearchForm search);
    }
}
