using GRP.Core;
using GRP.Data.UnitOfWork;
using System.Collections.Generic;

namespace GRP.Logic
{
    public class ComboBL
    {
        public static IEnumerable<dynamic> GetAll()
        {
            IEnumerable<dynamic> lista;
            using (var uow = new UnitOfWork())
            {
                lista = uow.ComboRepository.GetAllWithRelations();
            };
            return lista;
        }
    }
}