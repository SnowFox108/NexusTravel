using System;
using System.Collections.Generic;
using System.Text;

namespace NexusTravel.AirEngine.BritishAirway
{
    public class FlightSearchService : IFlightSearchService
    {
        private readonly IAirShoppingService _airShoppingService;

        public FlightSearchService(IAirShoppingService airShoppingService)
        {
            _airShoppingService = airShoppingService;
        }

        public string Search()
        {
            return _airShoppingService.Say();
        }
    }
}
