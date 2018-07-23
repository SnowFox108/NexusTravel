using NexusTravel.AirEngine.BritishAirway.Models.Common;

namespace NexusTravel.AirEngine.BritishAirway.Builders
{
    public class DocumentFactory : IDocumentFactory
    {
        public Document Create()
        {
            return new Document()
            {
                Name = "BA"
            };
        }
    }
}
