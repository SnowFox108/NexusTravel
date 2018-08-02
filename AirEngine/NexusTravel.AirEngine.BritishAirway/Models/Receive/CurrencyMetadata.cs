using System.Xml.Serialization;

namespace NexusTravel.AirEngine.BritishAirway.Models.Receive
{
    public class CurrencyMetadata
    {
        [XmlAttribute]
        public string MetadataKey { get; set; }

        public int Decimals { get; set; }
    }
}
