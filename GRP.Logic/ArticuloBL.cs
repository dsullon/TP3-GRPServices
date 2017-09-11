using GRP.Core;
using GRP.Data.UnitOfWork;
using System.Collections.Generic;

namespace GRP.Logic
{
    public class ArticuloBL
    {
        #region . CONSTRUCT .

        private static ArticuloBL instance;

        private ArticuloBL() { }

        public static ArticuloBL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ArticuloBL();
                }
                return instance;
            }
        }

        #endregion
        
        #region . PUBLIC METHOD .

        public static IEnumerable<Articulo> GetAll()
        {
            IEnumerable<Articulo> lista;
            using (var uow = new UnitOfWork())
            {
                lista = uow.ArticuloRepository.GetAll();
            }
            return lista;
        }

        public static IEnumerable<dynamic> GetUmbral()
        {
            IEnumerable<dynamic> lista;
            using (var uow = new UnitOfWork())
            {
                lista = uow.ArticuloRepository.GetUmbral();
            }
            return lista;
        }

        public static dynamic GetUmbralPerId(int id)
        {
            dynamic data;
            using (var uow = new UnitOfWork())
            {
                data = uow.ArticuloRepository.GetUmbralPerId(id);
            }
            return data;
        }

        #endregion
    }
}