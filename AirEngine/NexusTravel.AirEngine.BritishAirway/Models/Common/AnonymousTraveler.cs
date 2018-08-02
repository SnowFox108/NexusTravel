using System.Xml.Serialization;

namespace NexusTravel.AirEngine.BritishAirway.Models.Common
{
    public class AnonymousTraveler
    {
        [XmlAttribute]
        public string ObjectKey { get; set; }
        public string PTC { get; set; }
        public Age Age { get; set; }
    }
}
