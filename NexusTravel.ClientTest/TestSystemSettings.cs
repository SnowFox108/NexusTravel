using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Logging;
using NexusTravel.Dal.Models;
using NexusTravel.Main.StaticDataCache;

namespace NexusTravel.ClientTest
{
    public class TestSystemSettings
    {
        private readonly ILogger<TestSystemSettings> _logger;
        private readonly SystemSettingDto _systemSetting;
        public TestSystemSettings(
            ILogger<TestSystemSettings> logger, 
            IStaticDataCachingService staticDataCachingService)
        {
            _logger = logger;
            _systemSetting = staticDataCachingService.SystemSettings();
        }

        public void Display()
        {
            Console.WriteLine($"Url: {_systemSetting.AirShoppingApiUrl}");
            Console.WriteLine($"Key: {_systemSetting.AirShoppingClientKey}");
            //_logger.LogInformation($"Logging Test Url: {_systemSetting.AirShoppingApiUrl}");


        }
    }
}
