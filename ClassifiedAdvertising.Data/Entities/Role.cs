using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace ClassifiedAdvertising.Data.Entities
{
    public class Role : IdentityRole<int, UserRole, IdentityRoleClaim<int>>, IBaseEntity
    {
        public IList<UserRole> Users { get; set; } = new List<UserRole>();
    }
}
