using GRP.Core;
using GRP.Data.UnitOfWork;
using System.Collections.Generic;

namespace GRP.Logic
{
    public class ProductoBL
    {
        public static IEnumerable<Producto> GetAll()
        {
            IEnumerable<Producto> lista;
            using (var uow = new UnitOfWork())
            {
                lista = uow.ProductoRepository.GetAll();
            };
            return lista;
        }

        public static Producto Get(int id)
        {
            Producto producto;
            using (var uow = new UnitOfWork())
            {
                producto = uow.ProductoRepository.Get(id);
            }
            return producto;
        }

        public static IEnumerable<dynamic> GetDetails(int id)
        {
            IEnumerable<dynamic> lista;
            using (var uow = new UnitOfWork())
            {
                lista = uow.ProductoArticuloRepository.GetAll(id);
            }
            return lista;
        }

        public static IEnumerable<dynamic> GetPerItem(int[] id)
        {
            IEnumerable<dynamic> lista;
            using (var uow = new UnitOfWork())
            {
                lista = uow.ProductoRepository.GetPerItem(id);
            }
            return lista;
        }

        public static void Add(Producto producto)
        {
            using (var uow = new UnitOfWork())
            {
                uow.ProductoRepository.Add(producto);
                ProductoArticulo insumo;
                for (int i = 0; i < producto.Insumos.Count; i++)
                {
                    insumo = producto.Insumos[i];
                    insumo.IdProducto = producto.Id;
                    uow.ProductoArticuloRepository.Add(insumo);
                }
                uow.Commit();
            }
        }

        public static void Update(Producto producto)
        {
            using (var uow = new UnitOfWork())
            {
                uow.ProductoArticuloRepository.Remove(producto.Id);
                uow.ProductoRepository.Update(producto);
                ProductoArticulo insumo;
                for (int i = 0; i < producto.Insumos.Count; i++)
                {
                    insumo = producto.Insumos[i];
                    insumo.IdProducto = producto.Id;
                    uow.ProductoArticuloRepository.Add(insumo);
                }
                uow.Commit();
            }
        }

        public static void Remove(int id)
        {
            using (var uow = new UnitOfWork())
            {
                uow.ProductoRepository.Remove(id);
                uow.Commit();
            }
        }
    }
}