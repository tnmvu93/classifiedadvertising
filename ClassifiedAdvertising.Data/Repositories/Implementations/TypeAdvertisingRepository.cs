using ClassifiedAdvertising.Data.Entities;

namespace ClassifiedAdvertising.Data.Repositories.Implementations
{
    public class TypeAdvertisingRepository : BaseRepository<TypeAdvertising>, ITypeAdvertisingRepository
    {
        public TypeAdvertisingRepository(ClassifiedAdvertisingDbContext dbContext)
            : base(dbContext)
        {

        }
    }
}
