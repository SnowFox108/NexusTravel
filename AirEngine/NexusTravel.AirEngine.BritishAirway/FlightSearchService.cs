using AutoMapper;
using NexusTravel.AirEngine.BritishAirway.Infrastructures;
using NexusTravel.AirEngine.BritishAirway.Models;
using NexusTravel.AirEngine.BritishAirway.Models.Receive;

namespace NexusTravel.AirEngine.BritishAirway
{
    public class FlightSearchService : IFlightSearchService
    {
        private readonly IAirShoppingService _airShoppingService;
        private readonly IMapper _mapper;

        public FlightSearchService(
            IAirShoppingService airShoppingService, 
            IMapper mapper)
        {
            _airShoppingService = airShoppingService;
            _mapper = mapper;
        }

        public AirShoppingRS Search(FlightSearchForm search)
        {
            var flightSearch = _mapper.Map<FlightSearch>(search);
            return _airShoppingService.FlightSearch(flightSearch);
        }

    }
}
