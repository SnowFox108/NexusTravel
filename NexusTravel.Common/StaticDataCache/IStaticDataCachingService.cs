using NexusTravel.Dal.Models;

namespace NexusTravel.Common.StaticDataCache
{
    public interface IStaticDataCachingService
    {
        SystemSettingDto SystemSettings();
    }
}
