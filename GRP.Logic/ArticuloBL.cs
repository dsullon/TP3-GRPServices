using GRP.Core;
using GRP.Data.UnitOfWork;
using System.Collections.Generic;

namespace GRP.Logic
{
    public class ArticuloBL
    {
        public static IEnumerable<Articulo> GetAll()
        {
            IEnumerable<Articulo> lista;
            using (var uow = new UnitOfWork())
            {
                lista = uow.ArticuloRepository.GetAll();
            }
            return lista;
        }
    }
}