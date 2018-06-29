using NexusTravel.Dal.Models;

namespace NexusTravel.Main.StaticDataCache
{
    public interface IStaticDataCachingService
    {
        SystemSettingDto SystemSettings();
    }
}
