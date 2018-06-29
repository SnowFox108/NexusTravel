using System.Data.SqlClient;

namespace NexusTravel.Dal
{
    public interface IConnectionFactory
    {
        SqlConnection OpenNexusTravelConnection();
    }
}
