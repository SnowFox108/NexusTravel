using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Logging;
using NexusTravel.AirEngine.BritishAirway;
using NexusTravel.Common.StaticDataCache;
using NexusTravel.Dal.Models;

namespace NexusTravel.ClientTest
{
    public class TestSystemSettings
    {
        private readonly ILogger<TestSystemSettings> _logger;
        private readonly SystemSettingDto _systemSetting;
        private readonly IFlightSearchService _flightSearchService;
        public TestSystemSettings(
            ILogger<TestSystemSettings> logger, 
            IStaticDataCachingService staticDataCachingService, 
            IFlightSearchService flightSearchService)
        {
            _logger = logger;
            _flightSearchService = flightSearchService;
            _systemSetting = staticDataCachingService.SystemSettings();
        }

        public void Display()
        {
            Console.WriteLine($"Url: {_systemSetting.AirShoppingApiUrl}");
            Console.WriteLine($"Key: {_systemSetting.AirShoppingClientKey}");
            Console.WriteLine($"From Inner: {_flightSearchService.Search()}");
            //_logger.LogInformation($"Logging Test Url: {_systemSetting.AirShoppingApiUrl}");


        }
    }
}
