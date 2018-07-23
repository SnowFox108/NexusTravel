using NexusTravel.AirEngine.BritishAirway.Models.Infrastructures;

namespace NexusTravel.AirEngine.BritishAirway.Infrastructures
{
    public interface IXmlService
    {
        string CreateXmlStringFromObject<T>(object model) where T : ISoapObject;
    }
}
