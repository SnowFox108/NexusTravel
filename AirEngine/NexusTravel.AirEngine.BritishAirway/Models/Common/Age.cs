using System;
using System.Xml.Serialization;

namespace NexusTravel.AirEngine.BritishAirway.Models.Common
{
    public class Age
    {
        [XmlIgnore]
        public DateTime BirthDate { get; set; }

        [XmlElement("BirthDate")]
        public string BirthDateString
        {
            get => BirthDate.ToString("yyyy-MM-dd");
            set => BirthDate = DateTime.Parse(value);
        }
    }
}
