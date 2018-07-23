using NexusTravel.AirEngine.BritishAirway.Models;

namespace NexusTravel.AirEngine.BritishAirway
{
    public class FlightSearchService : IFlightSearchService
    {
        private readonly IAirShoppingService _airShoppingService;

        public FlightSearchService(IAirShoppingService airShoppingService)
        {
            _airShoppingService = airShoppingService;
        }

        public string Search(FlightSearch search)
        {
            return _airShoppingService.FlightSearch(search);
        }
    }
}
