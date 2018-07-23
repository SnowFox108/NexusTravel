using NexusTravel.AirEngine.BritishAirway.Models;

namespace NexusTravel.AirEngine.BritishAirway.Builders
{
    public interface IElementBuilder<out T>
    {
        T Create(FlightSearch search);
    }
}
