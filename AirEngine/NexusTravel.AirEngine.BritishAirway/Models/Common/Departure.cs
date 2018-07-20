using System;
using System.Xml.Serialization;

namespace NexusTravel.AirEngine.BritishAirway.Models.Common
{
    internal class Departure
    {
        public string AirportCode { get; set; }
        [XmlIgnore]
        public DateTime Date { get; set; }

        [XmlElement("Date")]
        public string DateString
        {
            get => Date.ToString("yyyy-MM-dd");
            set => Date = DateTime.Parse(value);
        }
    }
}
