using ClassifiedAdvertising.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace ClassifiedAdvertising.Data.Repositories.Implementations
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly ClassifiedAdvertisingDbContext _dbContext;

        public BaseRepository(ClassifiedAdvertisingDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Create(TEntity entity)
        {
            _dbContext.Set<TEntity>().AddAsync(entity);
        }

        public void Delete(TEntity entity)
        {
            _dbContext.Set<TEntity>().Remove(entity);
        }

        public IQueryable<TEntity> GetAll()
        {
            var list = _dbContext.Set<TEntity>().AsQueryable();
            return list;
        }

        public async Task<TEntity> GetById(int id)
        {
            var entity = await _dbContext.Set<TEntity>().FirstOrDefaultAsync(x => x.Id == id);
            return entity;
        }

        public void Update(TEntity entity)
        {
            _dbContext.Set<TEntity>().Update(entity);
        }

        public async Task SaveChanges()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
