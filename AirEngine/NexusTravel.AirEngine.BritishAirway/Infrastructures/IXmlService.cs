using NexusTravel.AirEngine.BritishAirway.Models.Infrastructures;
using NexusTravel.AirEngine.BritishAirway.Models.Receive;

namespace NexusTravel.AirEngine.BritishAirway.Infrastructures
{
    public interface IXmlService
    {
        string CreateXmlStringFromObject<T>(object model) where T : ISoapObject;
        AirShoppingRS AirShoppingParser(string xml);
    }
}
