using GRP.Core;
using GRP.Data.UnitOfWork;
using System.Collections.Generic;

namespace GRP.Logic
{
    public class CategoriaBL
    {
        public static IEnumerable<Categoria> GetAll()
        {
            IEnumerable<Categoria> lista;
            using (var uow = new UnitOfWork())
            {
                lista = uow.CategoriaRepository.GetAll();
            }
            return lista;
        }
    }
}