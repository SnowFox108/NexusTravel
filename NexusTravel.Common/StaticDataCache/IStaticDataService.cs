using NexusTravel.Dal.Models;

namespace NexusTravel.Common.StaticDataCache
{
    public interface IStaticDataService
    {
        SystemSettingDto GetSystemSetting();
    }
}
