using NexusTravel.AirEngine.BritishAirway.Models;

namespace NexusTravel.AirEngine.BritishAirway.Builders
{
    internal interface IElementBuilder<out T>
    {
        T Create(FlightSearch search);
    }
}
