using Microsoft.Extensions.DependencyInjection;
using NexusTravel.AirEngine.BritishAirway.Builders;
using NexusTravel.AirEngine.BritishAirway.Infrastructures;

namespace NexusTravel.AirEngine.BritishAirway.Ioc
{
    public static class AirShoppingInstaller
    {
        public static void AddAirShopping(this IServiceCollection service)
        {
            service.AddTransient<IDocumentFactory, DocumentFactory>();
            service.AddTransient<IPartyBuilder, PartyBuilder>();
            service.AddTransient<ITravelerBuilder, TravelerBuilder>();
            service.AddTransient<ICoreQueryBuilder, CoreQueryBuilder>();
            service.AddTransient<IPreferenceBuilder, PreferenceBuilder>();

            service.AddTransient<IAirShoppingService, AirShoppingService>();
            service.AddTransient<IFlightSearchService, FlightSearchService>();

            service.AddTransient<IXmlService, XmlService>();
            service.AddTransient<ISoapService, SoapService>();
        }
    }
}
