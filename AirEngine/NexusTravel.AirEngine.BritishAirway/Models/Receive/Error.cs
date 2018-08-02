using System.Xml.Serialization;

namespace NexusTravel.AirEngine.BritishAirway.Models.Receive
{
    public class Error
    {
        [XmlAttribute]
        public string ShortText { get; set; }
        [XmlAttribute]
        public string Code { get; set; }
    }
}
