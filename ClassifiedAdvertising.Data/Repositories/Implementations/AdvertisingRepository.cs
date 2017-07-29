using ClassifiedAdvertising.Data.Entities;

namespace ClassifiedAdvertising.Data.Repositories.Implementations
{
    public class AdvertisingRepository : BaseRepository<Advertising>, IAdvertisingRepository
    {
        public AdvertisingRepository(ClassifiedAdvertisingDbContext dbContext)
            : base(dbContext)
        {
        }
    }
}
