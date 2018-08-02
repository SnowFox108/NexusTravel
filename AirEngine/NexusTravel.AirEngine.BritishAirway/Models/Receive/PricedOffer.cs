using System.Collections.Generic;
using System.Xml.Serialization;

namespace NexusTravel.AirEngine.BritishAirway.Models.Receive
{
    public class PricedOffer
    {
        [XmlElement("OfferPrice")]
        public List<OfferPrice> OfferPrices { get; set; }
    }
}
