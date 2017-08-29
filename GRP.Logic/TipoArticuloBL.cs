using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GRP.Core;
using GRP.Data;

namespace GRP.Logic
{
    public class TipoArticuloBL
    {
        private static IRepository<TipoArticulo> repository = new TipoArticuloRepository();

        public static IEnumerable<TipoArticulo> Listar()
        {
            return repository.List();
        }
    }
}
