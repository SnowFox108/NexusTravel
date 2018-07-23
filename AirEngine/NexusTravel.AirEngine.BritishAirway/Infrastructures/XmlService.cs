using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NexusTravel.AirEngine.BritishAirway.Models.Infrastructures;

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
    }
}
