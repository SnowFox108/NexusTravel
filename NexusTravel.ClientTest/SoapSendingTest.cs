using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Logging;
using NexusTravel.AirEngine.BritishAirway;
using NexusTravel.AirEngine.BritishAirway.Enums;
using NexusTravel.AirEngine.BritishAirway.Models;
using NexusTravel.Common.StaticDataCache;
using NexusTravel.Dal.Models;

namespace NexusTravel.ClientTest
{
    public class SoapSendingTest
    {
        private readonly ILogger<TestSystemSettings> _logger;
        private readonly SystemSettingDto _systemSetting;
        private readonly IFlightSearchService _flightSearchService;

        public SoapSendingTest(
            ILogger<TestSystemSettings> logger,
            IStaticDataCachingService staticDataCachingService,
            IFlightSearchService flightSearchService)
        {
            _logger = logger;
            _systemSetting = staticDataCachingService.SystemSettings();
            _flightSearchService = flightSearchService;
        }

        public void Display()
        {
            var criteria = new FlightSearchForm()
            {
                TripType = TripType.Return,
                From = "LHR",
                To = "DME",
                Departure = DateTime.Today.AddDays(30),
                Return = DateTime.Today.AddDays(37),
                FlightClass = FlightClass.Economy,
                NumberOfAdults = 1,
                NumberOfChildren = 0,
                NumberOfInfant = 0,
                IsDirectFlight = false,
                IsDateFlexible = false
            };
            var result = _flightSearchService.Search(criteria);
            Console.WriteLine(result);
        }
    }
}
