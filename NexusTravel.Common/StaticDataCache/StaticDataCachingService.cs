using Microsoft.Extensions.Caching.Memory;
using NexusTravel.Dal.Models;

namespace NexusTravel.Common.StaticDataCache
{
    public class StaticDataCachingService : IStaticDataCachingService, ICachingService
    {
        private readonly IMemoryCache _cache;
        private readonly IStaticDataService _staticDataService;

        private const string SystemSettingkey = "SystemSettings";

        public StaticDataCachingService(
            IMemoryCache cache, 
            IStaticDataService staticDataService)
        {
            _cache = cache;
            _staticDataService = staticDataService;
        }
        public void ClearCache()
        {
            _cache.Remove(SystemSettingkey);
        }

        public SystemSettingDto SystemSettings()
        {
            return _cache.GetOrCreate(SystemSettingkey, entry => _staticDataService.GetSystemSetting());
        }

    }
}
