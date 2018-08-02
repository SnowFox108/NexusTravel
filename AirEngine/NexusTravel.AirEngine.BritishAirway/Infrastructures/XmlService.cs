using System;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using NexusTravel.AirEngine.BritishAirway.Models.Infrastructures;
using NexusTravel.AirEngine.BritishAirway.Models.Receive;

namespace NexusTravel.AirEngine.BritishAirway.Infrastructures
{
    public class XmlService : IXmlService
    {
        public string CreateXmlStringFromObject<T>(object model) where T : ISoapObject
        {
            var serializer = new XmlSerializer(typeof(T));
            var settings = new XmlWriterSettings
            {
                Indent = true,
                OmitXmlDeclaration = true
            };

            using (var stream = new StringWriter())
            using (var writer = XmlWriter.Create(stream, settings))
            {
                serializer.Serialize(writer, model);
                return stream.ToString();
            }
        }

        public AirShoppingRS AirShoppingParser(string xml)
        {
            XDocument xDoc = XDocument.Load(new StringReader(xml));
            var unwrappedResponse = xDoc.Descendants((XNamespace) "http://schemas.xmlsoap.org/soap/envelope/" + "Body");
            var body = unwrappedResponse.First().FirstNode.ToString();

            XmlSerializer deSerializer = new XmlSerializer(typeof(AirShoppingRS), "http://www.iata.org/IATA/EDIST");
            using (StringReader reader = new StringReader(body))
            {
                var result = (AirShoppingRS) deSerializer.Deserialize(reader);
                return result;
            }
        }
    }
}
