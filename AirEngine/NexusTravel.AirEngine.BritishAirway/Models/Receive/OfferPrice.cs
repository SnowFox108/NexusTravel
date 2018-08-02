using System.Xml.Serialization;

namespace NexusTravel.AirEngine.BritishAirway.Models.Receive
{
    public class OfferPrice
    {
        [XmlAttribute]
        public int OfferItemID { get; set; }

        public RequestedDate RequestedDate { get; set; }
    }
}
