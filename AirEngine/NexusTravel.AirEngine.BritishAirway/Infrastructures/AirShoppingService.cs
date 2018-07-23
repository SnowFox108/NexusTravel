using System;
using Microsoft.Extensions.Logging;
using NexusTravel.AirEngine.BritishAirway.Builders;
using NexusTravel.AirEngine.BritishAirway.Models;
using NexusTravel.AirEngine.BritishAirway.Models.Infrastructures;
using NexusTravel.AirEngine.BritishAirway.Models.Send;

namespace NexusTravel.AirEngine.BritishAirway.Infrastructures
{
    public class AirShoppingService : IAirShoppingService
    {
        private readonly ILogger<AirShoppingService> _logger;
        private readonly IXmlService _xmlService;
        private readonly ISoapService _soapService;

        private readonly IDocumentFactory _documentFactory;
        private readonly IPartyBuilder _partyBuilder;
        private readonly ITravelerBuilder _travelerBuilder;
        private readonly ICoreQueryBuilder _coreQueryBuilder;
        private readonly IPreferenceBuilder _preferenceBuilder;

        public AirShoppingService(
            ILogger<AirShoppingService> logger,
            IXmlService xmlService,
            ISoapService soapService, 
            IDocumentFactory documentFactory, 
            IPartyBuilder partyBuilder, 
            ITravelerBuilder travelerBuilder, 
            ICoreQueryBuilder coreQueryBuilder, 
            IPreferenceBuilder preferenceBuilder)
        {
            _logger = logger;
            _xmlService = xmlService;
            _soapService = soapService;
            _documentFactory = documentFactory;
            _partyBuilder = partyBuilder;
            _travelerBuilder = travelerBuilder;
            _coreQueryBuilder = coreQueryBuilder;
            _preferenceBuilder = preferenceBuilder;
        }

        public string FlightSearch(FlightSearch search)
        {
            var xml = CreateXml(search);
            var result = _soapService.SendRequest(xml);
            return result;
        }

        public string CreateXml(FlightSearch search)
        {
            var airShoppingRQ = new AirShoppingRQ();
            airShoppingRQ.Document = _documentFactory.Create();
            airShoppingRQ.Party = _partyBuilder.Create();
            airShoppingRQ.Travelers = _travelerBuilder.Create(search);
            airShoppingRQ.CoreQuery = _coreQueryBuilder.Create(search);
            airShoppingRQ.Preference = _preferenceBuilder.Create(search);

            var soap = new SoapEnvelope()
            {
                body = new ResponseBody<AirShoppingRQ>
                {
                    AirShoppingRQ = airShoppingRQ
                }
            };

            return _xmlService.CreateXmlStringFromObject<SoapEnvelope>(soap);

        }
    }
}
