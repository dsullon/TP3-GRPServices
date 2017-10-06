using Dapper;
using GRP.Core;
using GRP.Data.Repositories.Contract;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Linq;

namespace GRP.Data.Repositories
{
    internal class ProductoRepository : RepositoryBase, IProductoRepository
    {
        public ProductoRepository(IDbTransaction transaction)
            : base(transaction)
        {
        }

        public void Add(Producto entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            StringBuilder sql = new StringBuilder();
            sql.Append("Insert into GRP.tb_Producto(umbralCosto, elaboracion, estado, precio, ");
            sql.Append("costo, nombre, porciones, codCategoria)");
            sql.Append("values(@umbral, @elaboracion, @estado, @precio, ");
            sql.Append("@costo, @nombre, @porciones, @categoria)");
            sql.Append("SELECT SCOPE_IDENTITY()");

            entity.Id = Connection.ExecuteScalar<int>(
                sql.ToString(),
                param: new
                {
                    umbral = entity.Umbral,
                    elaboracion = entity.Elaboracion,
                    estado = 1,
                    precio = entity.Precio,
                    costo = entity.Costo,
                    nombre = entity.Nombre,
                    porciones = entity.Porciones,
                    categoria = entity.IdCategoria
                },
                transaction: Transaction
            );
        }

        public Producto Get(int Id)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("Select codProducto as Id, nombre, elaboracion, umbralCosto as Umbral, ");
            sql.Append("costo, precio, porciones, codCategoria as IdCategoria, Estado ");
            sql.Append("From GRP.tb_Producto ");
            sql.Append("Where codProducto = @IdProducto");
            var data = Connection.QueryFirstOrDefault<Producto>(sql.ToString(),
                param: new
                {
                    IdProducto = Id
                },
                transaction: Transaction);
            return data;
        }

        public IEnumerable<Producto> GetAll()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("Select codProducto as Id, A.nombre, elaboracion, umbralCosto as Umbral, ");
            sql.Append("costo, precio, porciones, A.codCategoria as IdCategoria, B.Nombre as Categoria, Estado ");
            sql.Append("From GRP.tb_Producto A Inner Join GRP.tb_categoria B ");
            sql.Append("On A.codCategoria = B.codCategoria ");
            var lista = Connection.Query<Producto>(sql.ToString(),
                transaction: Transaction);
            return lista;
        }

        public IEnumerable<dynamic> GetPerItem(int[] Id)
        {
            string ids = String.Join(",", Id.Select(p => p.ToString()).ToArray());
            StringBuilder sql = new StringBuilder();
            sql.Append("Select A.codProducto as Id, nombre, elaboracion, umbralCosto as Umbral, ");
            sql.Append("A.costo, precio, porciones, codCategoria as IdCategoria ");
            sql.Append("From GRP.tb_Producto A Inner Join GRP.tb_articuloProducto B ");
            sql.Append("On A.codProducto = B.codProducto ");
            sql.Append("Where (',' + @articulo + ',' LIKE '%,' + CONVERT(nvarchar(MAX), B.codArticulo) + ',%')");

            
            var lista = Connection.Query(sql.ToString(),
                param: new
                {
                    articulo = ids
                },
                transaction: Transaction);
            return lista;
        }

        public void Remove(int id)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("Update GRP.tb_Producto set estado = 0 ");
            sql.Append("Where codProducto = @IdProducto");
            Connection.Execute(
                sql.ToString(),
                param: new
                {
                    IdProducto = id
                },
                transaction: Transaction
            );
        }

        public void Remove(Producto entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            Remove(entity.Id);
        }

        public void Update(Producto entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            StringBuilder sql = new StringBuilder();
            sql.Append("Update GRP.tb_Producto Set porciones = @porciones, ");
            sql.Append("codCategoria = @categoria, nombre = @nombre, costo = @costo, ");
            sql.Append("precio = @precio Where codProducto = @producto");

            Connection.Execute(
                sql.ToString(),
                param: new
                {
                    porciones = entity.Porciones,
                    categoria = entity.IdCategoria,
                    nombre = entity.Nombre,
                    costo = entity.Costo,
                    precio = entity.Precio,
                    producto = entity.Id
                },
                transaction: Transaction
            );
        }
    }
}