using Microsoft.Extensions.DependencyInjection;
using NexusTravel.AirEngine.BritishAirway.Infrastructures;

namespace NexusTravel.AirEngine.BritishAirway.Ioc
{
    public static class AirShoppingInstaller
    {
        public static void AddAirShopping(this IServiceCollection service)
        {
            service.AddTransient<IAirShoppingService, AirShoppingService>();
            service.AddTransient<IFlightSearchService, FlightSearchService>();

            service.AddTransient<ISoapService, SoapService>();
        }
    }
}
