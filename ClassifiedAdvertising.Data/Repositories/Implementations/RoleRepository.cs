using ClassifiedAdvertising.Data.Entities;

namespace ClassifiedAdvertising.Data.Repositories.Implementations
{
    public class RoleRepository : BaseRepository<Role>, IRoleRepository
    {
        public RoleRepository(ClassifiedAdvertisingDbContext dbContext)
            : base(dbContext)
        {

        }
    }
}
