using System.Xml.Serialization;

namespace NexusTravel.AirEngine.BritishAirway.Models.Receive
{
    public class SimpleCurrencyPrice
    {
        [XmlAttribute]
        public string Code { get; set; }
        [XmlText]
        public decimal Value { get; set; }
    }
}
