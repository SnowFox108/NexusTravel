using System.Collections.Generic;
using System.Xml.Serialization;
using NexusTravel.AirEngine.BritishAirway.Models.Common;

namespace NexusTravel.AirEngine.BritishAirway.Models.Receive
{
    public class AirShoppingRS
    {
        [XmlAttribute]
        public string Version { get; set; }

        public List<Error> Errors { get; set; }
        public Success Success { get; set; }

        public Document Document { get; set; }
        public ShoppingResponseID ShoppingResponseID { get; set; }
        public OffersGroup OffersGroup { get; set; }
        public DataLists DataLists { get; set; }
        public Metadata Metadata { get; set; }
    }
}
