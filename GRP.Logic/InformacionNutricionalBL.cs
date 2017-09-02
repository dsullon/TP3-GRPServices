using GRP.Core;
using GRP.Data.UnitOfWork;
using System.Collections.Generic;

namespace GRP.Logic
{
    public class InformacionNutricionalBL
    {
        public static IEnumerable<InformacionNutricional> GetAll()
        {
            IEnumerable<InformacionNutricional> lista;
            using (var uow = new UnitOfWork())
            {
                lista = uow.InformacionNutricionalRepository.GetAll();
            }
            return lista;
        }

        public static InformacionNutricional Get(int id)
        {
            InformacionNutricional nutricional;
            using (var uow = new UnitOfWork())
            {
                nutricional = uow.InformacionNutricionalRepository.Get(id);
            }
            return nutricional;
        }
    }
}
