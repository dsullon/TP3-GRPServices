using GRP.Core;
using System.Collections.Generic;

namespace GRP.Data.Repositories.Contract
{
    public interface IProductoRepository: IRepository<Producto>
    {
        IEnumerable<dynamic> GetPerItem(int Id);
    }
}
