using System.Collections.Generic;

namespace GRP.Data.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity Get(int Id);
        IEnumerable<TEntity> GetAll();
        void Add(TEntity entity);
        void Remove(TEntity entity);
        void Remove(int id);
        void Update(TEntity entity);
    }
}
