using Dapper;
using GRP.Core;
using GRP.Data.Repositories.Contract;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace GRP.Data.Repositories
{
    internal class ComboProductoRepository : RepositoryBase, IComboProductoRepository
    {
        public ComboProductoRepository(IDbTransaction transaction) 
            : base(transaction)
        {
        }

        public void Add(ComboProducto entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            StringBuilder sql = new StringBuilder();
            sql.Append("Insert into GRP.tb_comboProducto(codCombo, codProducto, esPrincipal, cantidad)");
            sql.Append("values(@combo, @producto, @principal, @cantidad)");

            Connection.Execute(
                sql.ToString(),
                param: new
                {
                    combo = entity.IdCombo,
                    producto = entity.IdProducto,
                    principal = entity.EsPrincipal,
                    cantidad = entity.Cantidad
                },
                transaction: Transaction
            );
        }

        public void Remove(int id)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("Delete From GRP.tb_comboProducto Where codCombo = @combo");

            Connection.Execute(
                sql.ToString(),
                param: new
                {
                    combo = id
                },
                transaction: Transaction
            );
        }

        public IEnumerable<dynamic> GetAll(int id)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("Select A.codProducto as IdProducto, B.Nombre, B.Precio, ");
            sql.Append("A.Cantidad, A.EsPrincipal ");
            sql.Append("From GRP.tb_comboProducto A Inner Join GRP.tb_producto B ");
            sql.Append("On A.codProducto = B.codProducto ");
            sql.Append("Where codCombo = @combo");
            var lista = Connection.Query(sql.ToString(),
                param: new
                {
                    combo = id
                },
                transaction: Transaction);
            return lista;
        }
    }
}