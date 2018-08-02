using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Microsoft.Web.Services3.Messaging;
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
            byte[] byteArray = Encoding.UTF8.GetBytes(xml);

            var stream = new MemoryStream(byteArray);

            ISoapFormatter formatter = new SoapPlainFormatter();
            var result = (AirShoppingRS)formatter.Deserialize(stream).GetBodyObject(typeof(AirShoppingRS), "http://www.iata.org/IATA/EDIST");
            stream.Close();

            return result;
        }
    }
}
