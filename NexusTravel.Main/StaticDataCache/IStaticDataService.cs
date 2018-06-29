using NexusTravel.Dal.Models;

namespace NexusTravel.Main.StaticDataCache
{
    public interface IStaticDataService
    {
        SystemSettingDto GetSystemSetting();
    }
}
