using Microsoft.Extensions.Configuration;
using NexusTravel.Dal;

namespace NexusTravel.ClientTest
{
    public class ConfigConnection : IConfigConnection
    {
        private readonly IConfigurationRoot _root;

        public ConfigConnection(IConfigurationRoot root)
        {
            _root = root;
        }


        public string ConnectionString => _root["ConnectionStrings:NexusTravel"];
    }

}
