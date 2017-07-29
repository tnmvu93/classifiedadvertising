using System.Collections.Generic;

namespace ClassifiedAdvertising.Data.Entities
{
    public class Role : BaseEntity
    {
        public string Name { get; set; }

        public List<UserRole> Roles { get; set; }
    }
}
