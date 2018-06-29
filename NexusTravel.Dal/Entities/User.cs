using System.Collections.Generic;
using NexusTravel.Infrastructure.Entities;

namespace NexusTravel.Dal.Entities
{
    public class User : IEntity
    {
        public int Id { get; set; }
        public string DisplayName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
    }
}
