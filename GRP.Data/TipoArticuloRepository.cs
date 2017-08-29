using GRP.Core;
using System.Collections.Generic;
using System.Data;
using GRP.Data.Infrastructure;

namespace GRP.Data
{
    public class TipoArticuloRepository: IRepository<TipoArticulo>
    {
        IConnectionFactory db;
        public IEnumerable<TipoArticulo> List()
        {
            var lista = new List<TipoArticulo>();
            return lista;
        }

        public bool Add(TipoArticulo tipo)
        {
            return true;
        }

        public bool Delete(TipoArticulo tipo)
        {
            return true;
        }

        public bool Update(TipoArticulo tipo)
        {
            return true;
        }

        public TipoArticulo FindById(int id)
        {
            return new TipoArticulo();
        }
    }
}
