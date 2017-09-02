﻿using GRP.Core;
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
    }
}