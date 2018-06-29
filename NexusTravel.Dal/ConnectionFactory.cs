using System.Data.SqlClient;

namespace NexusTravel.Dal
{
    public class ConnectionFactory : IConnectionFactory
    {
        private readonly IConfigConnection _config;

        public ConnectionFactory(IConfigConnection config)
        {
            _config = config;
        }
        public SqlConnection OpenNexusTravelConnection()
        {
            var connection = new SqlConnection(_config.ConnectionString);
            connection.Open();
            return connection;
        }
    }
}
