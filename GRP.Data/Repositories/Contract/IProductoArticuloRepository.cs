using GRP.Core;
using System.Collections.Generic;

namespace GRP.Data.Repositories.Contract
{
    public interface IProductoArticuloRepository
    {
        IEnumerable<dynamic> GetAll(int id);
        void Add(ProductoArticulo entity);
        void Remove(int id);
    }
}
