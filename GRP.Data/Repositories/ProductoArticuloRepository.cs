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

        public IEnumerable<dynamic> GetAll(int id)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("Select A.codArticulo as IdArticulo, B.UnidadMedida, ");
            sql.Append("Costo, Cantidad, Rendimiento, B.Nombre, Cast(((cantidad / (Rendimiento/100)) * Costo) as decimal(10,2)) as Importe, ");
            sql.Append("Cast((C.calorias * Cantidad) as decimal(10,2)) as Calorias, Cast((C.grasas * Cantidad) as decimal(10,2)) as Grasas, ");
            sql.Append("Cast((C.proteinas * Cantidad) as decimal(10,2)) as Proteinas, Cast((C.carbohidratos * Cantidad) as decimal(10,2)) as Carbohidratos ");
            sql.Append("From GRP.tb_articuloProducto A Inner Join GRP.tb_articulo B ");
            sql.Append("On A.codArticulo = B.codArticulo Inner Join GRP.tb_infnutricional C ");
            sql.Append("On A.codArticulo = C.codArticulo ");
            sql.Append("Where codProducto = @IdProducto");
            var lista = Connection.Query(sql.ToString(),
                param: new
                {
                    IdProducto = id
                },
                transaction: Transaction);
            return lista;
        }

        public void Remove(int id)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("Delete From GRP.tb_articuloProducto Where codProducto = @producto");

            Connection.Execute(
                sql.ToString(),
                param: new
                {
                    producto = id
                },
                transaction: Transaction
            );
        }
    }
}