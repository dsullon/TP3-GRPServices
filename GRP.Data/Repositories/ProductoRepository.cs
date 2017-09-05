using Dapper;
using GRP.Core;
using GRP.Data.Repositories.Contract;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

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
            sql.Append("costo, precio, porciones, codCategoria as IdCategoria ");
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
            sql.Append("Select codProducto as Id, nombre, elaboracion, umbralCosto as Umbral, ");
            sql.Append("costo, precio, porciones, codCategoria as IdCategoria ");
            sql.Append("From GRP.tb_Producto");
            var lista = Connection.Query<Producto>(sql.ToString(),
                transaction: Transaction);
            return lista;
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Producto entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Producto entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            StringBuilder sql = new StringBuilder();
            sql.Append("Update GRP.tb_Producto Set porciones = @porciones ");
            sql.Append("Where codProducto = @producto");

            Connection.Execute(
                sql.ToString(),
                param: new
                {
                    porciones = entity.Porciones,
                    producto = entity.Id
                },
                transaction: Transaction
            );
        }
    }
}