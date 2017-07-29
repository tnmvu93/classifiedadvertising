using ClassifiedAdvertising.Data.Entities;

namespace ClassifiedAdvertising.Data.Repositories.Implementations
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(ClassifiedAdvertisingDbContext dbContext)
            : base(dbContext)
        {
        }
    }
}
