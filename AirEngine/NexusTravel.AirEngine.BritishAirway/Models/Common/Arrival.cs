using System;
using System.Xml.Serialization;

namespace NexusTravel.AirEngine.BritishAirway.Models.Common
{
    public class Arrival
    {
        public string AirportCode { get; set; }
        [XmlIgnore]
        public DateTime Date { get; set; }

        [XmlElement("Date")]
        public string DateString
        {
            get
            {
                if (Date == new DateTime())
                    return null;
                return Date.ToString("yyyy-MM-dd");
            }
            set => Date = DateTime.Parse(value);
        }
        public string Time { get; set; }
        public int ChangeOfDay { get; set; }
        public string AirportName { get; set; }
        public Terminal Terminal { get; set; }

    }
}
