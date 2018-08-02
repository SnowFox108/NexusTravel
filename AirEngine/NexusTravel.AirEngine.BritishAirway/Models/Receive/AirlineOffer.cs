using System.Xml.Serialization;

namespace NexusTravel.AirEngine.BritishAirway.Models.Receive
{
    public class AirlineOffer
    {
        [XmlAttribute]
        public bool RequestedDateInd { get; set; }

        public PricedOffer PricedOffer { get; set; }
    }
}
