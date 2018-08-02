using NexusTravel.AirEngine.BritishAirway.Models;
using NexusTravel.AirEngine.BritishAirway.Models.Receive;

namespace NexusTravel.AirEngine.BritishAirway.Infrastructures
{
    public interface IAirShoppingService
    {
        AirShoppingRS FlightSearch(FlightSearch search);
    }
}
