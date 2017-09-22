using GRP.Core;
using System.Collections.Generic;

namespace GRP.Data.Repositories.Contract
{
    public interface IComboProductoRepository
    {
        IEnumerable<dynamic> GetAll(int id);
        void Add(ComboProducto entity);
        void Remove(int id);
    }
}