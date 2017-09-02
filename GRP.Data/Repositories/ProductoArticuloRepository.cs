using Dapper;
using GRP.Core;
using GRP.Data.Repositories.Contract;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace GRP.Data.Repositories
{
    internal class ProductoArticuloRepository : RepositoryBase, IProductoArticuloRepository
    {
        public ProductoArticuloRepository(IDbTransaction transaction)
            : base(transaction)
        {
        }

        public void Add(ProductoArticulo entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            StringBuilder sql = new StringBuilder();
            sql.Append("Insert into GRP.tb_articuloProducto(codArticulo, codProducto, costo, cantidad, rendimiento)");
            sql.Append("values(@articulo, @producto, @costo, @cantidad, @rendimiento)");

            Connection.Execute(
                sql.ToString(),
                param: new
                {
                    articulo = entity.IdArticulo,
                    producto = entity.IdProducto,
                    costo = entity.Costo,
                    cantidad = entity.Cantidad,
                    rendimiento = entity.Rendimiento
                },
                transaction: Transaction
            );
        }

        public ProductoArticulo Get(int Id)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("Select codProducto as Id, nombre, elaboracion, umbralCosto as Umbral, ");
            sql.Append("costo, precio, porciones, codCategoria as IdCategoria ");
            sql.Append("From GRP.tb_Producto ");
            sql.Append("Where codProducto = @IdProducto");
            var data = Connection.QueryFirstOrDefault<ProductoArticulo>(sql.ToString(),
                param: new
                {
                    IdProducto = Id
                },
                transaction: Transaction);
            return data;
        }

        public IEnumerable<ProductoArticulo> GetAll()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("Select codProducto as Id, nombre, elaboracion, umbralCosto as Umbral, ");
            sql.Append("costo, precio, porciones, codCategoria as IdCategoria ");
            sql.Append("From GRP.tb_Producto");
            var lista = Connection.Query<ProductoArticulo>(sql.ToString(),
                transaction: Transaction);
            return lista;
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(ProductoArticulo entity)
        {
            throw new NotImplementedException();
        }

        public void Update(ProductoArticulo entity)
        {
            throw new NotImplementedException();
        }
    }
}
