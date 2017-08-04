using ClassifiedAdvertising.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace ClassifiedAdvertising.Data.Extensions
{
    public class ClassifiedAdvertisingRoleStore : RoleStore<Role, ClassifiedAdvertisingDbContext, int, UserRole, IdentityRoleClaim<int>>
    {
        public ClassifiedAdvertisingRoleStore(ClassifiedAdvertisingDbContext context) : base(context)
        {
        }
    }
}
