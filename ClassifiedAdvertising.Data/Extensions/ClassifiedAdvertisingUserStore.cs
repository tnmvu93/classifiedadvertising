using ClassifiedAdvertising.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace ClassifiedAdvertising.Data.Extensions
{
    public class ClassifiedAdvertisingUserStore : UserStore<User, Role, ClassifiedAdvertisingDbContext, int, IdentityUserClaim<int>, UserRole,
        IdentityUserLogin<int>, IdentityUserToken<int>, IdentityRoleClaim<int>>
    {
        public ClassifiedAdvertisingUserStore(ClassifiedAdvertisingDbContext context, IdentityErrorDescriber describer) : base(context, describer)
        {
        }
    }
}
