using System.Collections.Generic;
using NexusTravel.Dal.Entities;
using Dapper;

namespace NexusTravel.Dal.Queries
{
    public interface ISystemSettingQuery
    {
        IEnumerable<SystemSetting> GetSystemSettings();
    }
    public class SystemSettingQuery : ISystemSettingQuery
    {
        private readonly IConnectionFactory _connectionFactory;

        public SystemSettingQuery(IConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public IEnumerable<SystemSetting> GetSystemSettings()
        {
            const string sql = @"SELECT * FROM [SystemSettings]";

            using (var connection = _connectionFactory.OpenNexusTravelConnection())
            {
                return connection.Query<SystemSetting>(sql);
            }
        }
    }
}
