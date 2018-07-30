using NexusTravel.AirEngine.BritishAirway.Models;

namespace NexusTravel.AirEngine.BritishAirway
{
    public interface IFlightSearchService
    {
        string Search(FlightSearchForm search);
    }
}
