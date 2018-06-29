using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using NexusTravel.Dal.Models;
using NexusTravel.Dal.Queries;
using Microsoft.Extensions.Logging;

namespace NexusTravel.Main.StaticDataCache
{
    public class StaticDataService : IStaticDataService
    {
        private readonly ILogger<StaticDataService> _logger;
        private readonly ISystemSettingQuery _systemSettingQuery;

        public StaticDataService(ILogger<StaticDataService> logger, ISystemSettingQuery systemSettingQuery)
        {
            _systemSettingQuery = systemSettingQuery;
            _logger = logger;
        }

        public SystemSettingDto GetSystemSetting()
        {
            var tempSystemSettings = _systemSettingQuery.GetSystemSettings();

            var systemSetting = new SystemSettingDto();
            List<string> knownProperties = systemSetting.GetType().GetProperties().Select(x => x.Name).ToList();

            foreach (var tempSystemSetting in tempSystemSettings)
            {
                if (knownProperties.Contains(tempSystemSetting.Name))
                {
                    PropertyInfo property = systemSetting.GetType().GetProperty(tempSystemSetting.Name);
                    property.SetValue(systemSetting, tempSystemSetting.Value, null);
                }
                else
                    _logger.LogInformation($"Could not locate SystemSetting property with name {tempSystemSetting.Name}");
            }

            return systemSetting;
        }
    }
}
