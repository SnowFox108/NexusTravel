using System.Collections.Generic;

namespace NexusTravel.AirEngine.BritishAirway.Models.Common
{
    internal class TravelAgencySender
    {
        public string Name { get; set; }
        public List<Contact> Contacts { get; set; }
        public string IATA_Number { get; set; }
        public string AgencyID { get; set; }

        public TravelAgencySender()
        {
            Contacts = new List<Contact>();
        }
    }
}
