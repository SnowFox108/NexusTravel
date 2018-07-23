using System.Xml.Serialization;

namespace NexusTravel.AirEngine.BritishAirway.Models.Common
{
    [XmlType(TypeName = "Type")]
    public class PreferenceType
    {
        public string Code { get; set; }
    }
}
