using GRP.Core;
using GRP.Data.UnitOfWork;
using System.Collections.Generic;

namespace GRP.Logic
{
    public class ComboBL
    {
        public static IEnumerable<dynamic> GetAllWithRelations()
        {
            IEnumerable<dynamic> lista;
            using (var uow = new UnitOfWork())
            {
                lista = uow.ComboRepository.GetAllWithRelations();
            };
            return lista;
        }

        public static IEnumerable<Combo> GetAll()
        {
            IEnumerable<Combo> lista;
            using (var uow = new UnitOfWork())
            {
                lista = uow.ComboRepository.GetAll();
            };
            return lista;
        }

        public static Combo Get(int id)
        {
            Combo combo;
            using (var uow = new UnitOfWork())
            {
                combo = uow.ComboRepository.Get(id);
            }
            return combo;
        }

        public static IEnumerable<dynamic> GetDetails(int id)
        {
            IEnumerable<dynamic> lista;
            using (var uow = new UnitOfWork())
            {
                lista = uow.ComboProductoRepository.GetAll(id);
            }
            return lista;
        }

        public static void Add(Combo combo)
        {
            using (var uow = new UnitOfWork())
            {
                uow.ComboRepository.Add(combo);
                ComboProducto producto;
                for (int i = 0; i < combo.Productos.Count; i++)
                {
                    producto = combo.Productos[i];
                    producto.IdCombo = combo.Id;
                    uow.ComboProductoRepository.Add(producto);
                }
                uow.Commit();
            }
        }

        public static void Update(Combo combo)
        {
            using (var uow = new UnitOfWork())
            {
                uow.ComboProductoRepository.Remove(combo.Id);
                uow.ComboRepository.Update(combo);
                ComboProducto producto;
                for (int i = 0; i < combo.Productos.Count; i++)
                {
                    producto = combo.Productos[i];
                    producto.IdCombo = combo.Id;
                    uow.ComboProductoRepository.Add(producto);
                }
                uow.Commit();
            }
        }
    }
}