using NexusTravel.AirEngine.BritishAirway.Models.Common;
using NexusTravel.Common.StaticDataCache;
using NexusTravel.Dal.Models;

namespace NexusTravel.AirEngine.BritishAirway.Builders
{
    public class PartyBuilder: IPartyBuilder
    {
        private readonly SystemSettingDto _systemSetting;

        public PartyBuilder(IStaticDataCachingService staticDataCachingService)
        {
            _systemSetting = staticDataCachingService.SystemSettings();
        }
        public Party Create()
        {
            return new Party()
            {
                Sender = CreateSender()
            };
        }

        private Sender CreateSender()
        {
            return new Sender()
            {
                TravelAgencySender = CreateTravelAgencySender()
            };
        }

        private TravelAgencySender CreateTravelAgencySender()
        {
            var agencySender = new TravelAgencySender()
            {
                Name = _systemSetting.TravelAgencyName,
                IATA_Number = _systemSetting.TravelAgencyIataNumber,
                AgencyID = _systemSetting.TravelAgencyName
            };
            agencySender.Contacts.Add(CreateContact());

            return agencySender;
        }

        private Contact CreateContact()
        {
            return new Contact()
            {
                EmailContact = CreateEmailContact()
            };
        }

        private EmailContact CreateEmailContact()
        {
            return new EmailContact()
            {
                Address = _systemSetting.TravelAgencyEmail
            };
        }
    }
}
