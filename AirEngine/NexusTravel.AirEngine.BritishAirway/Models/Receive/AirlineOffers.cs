using System.Collections.Generic;
using System.Xml.Serialization;

namespace NexusTravel.AirEngine.BritishAirway.Models.Receive
{
    public class AirlineOffers
    {
        public int TotalOfferQuantity { get; set; }
        public string Owner { get; set; }

        [XmlElement("AirlineOffer")]
        public List<AirlineOffer> Offers { get; set; }

    }
}
