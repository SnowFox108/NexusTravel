using NexusTravel.Infrastructure.Entities;

namespace NexusTravel.Dal.Entities
{
    public class SystemSetting : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
