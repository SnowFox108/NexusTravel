using System.Xml.Serialization;

namespace NexusTravel.AirEngine.BritishAirway.Models.Infrastructures
{
    [XmlRoot(ElementName = "Body", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    internal class ResponseBody<T>
    {
        [XmlElement(Namespace = "http://www.iata.org/IATA/EDIST")]
        public T AirShoppingRQ { get; set; }
    }
}
