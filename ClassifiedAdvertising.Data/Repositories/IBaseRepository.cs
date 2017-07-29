using ClassifiedAdvertising.Data.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace ClassifiedAdvertising.Data.Repositories
{
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        Task<TEntity> GetById(int id);
        IQueryable<TEntity> GetAll();
        Task Create(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        Task SaveChanges();
    }
}
