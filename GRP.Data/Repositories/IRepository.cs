using System.Collections.Generic;

namespace GRP.Data.Repositories
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        bool Add(T entity);
        bool Delete(T entity);
        bool Update(T entity);
        T Get(int id);
    }
}
