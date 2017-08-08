using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace ClassifiedAdvertising.Data.Entities
{
    public class User : IdentityUser<int, IdentityUserClaim<int>, UserRole, IdentityUserLogin<int>, IdentityUserToken<int>>, IBaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public IList<UserRole> Roles { get; set; } =  new List<UserRole>();
    }
}
