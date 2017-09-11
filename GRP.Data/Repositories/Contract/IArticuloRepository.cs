using GRP.Core;
using System.Collections.Generic;

namespace GRP.Data.Repositories.Contract
{
    public interface IArticuloRepository: IRepository<Articulo>
    {
        IEnumerable<dynamic> GetUmbral();
        dynamic GetUmbralPerId(int Id);
    }
}
