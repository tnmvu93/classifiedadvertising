using ClassifiedAdvertising.Data.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace ClassifiedAdvertising.Data.Repositories
{
    public interface IBaseRepository<TEntity> where TEntity : class, IBaseEntity
    {
        Task<TEntity> GetByIdAsync(int id);
        IQueryable<TEntity> Query();
        void Create(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        Task SaveChangesAsync();
    }
}
