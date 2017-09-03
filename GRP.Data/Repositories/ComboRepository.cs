using Dapper;
using GRP.Core;
using GRP.Data.Repositories.Contract;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace GRP.Data.Repositories
{
    internal class ComboRepository : RepositoryBase, IComboRepository
    {
        public ComboRepository(IDbTransaction transaction) : 
            base(transaction)
        {
        }

        public void Add(Combo entity)
        {
            throw new NotImplementedException();
        }

        public Combo Get(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Combo> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<dynamic> GetAllWithRelations()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("Select codCombo as Id, A.Nombre, A.Descripcion, Precio, ");
            sql.Append("Descuento, Estado, A.codCategoria as IdCategoria, ");
            sql.Append("B.Nombre as Categoria, FechaCreacion, FechaModificacion ");
            sql.Append("From GRP.tb_combo A Inner Join GRP.tb_categoria B ");
            sql.Append("On A.codCategoria = B.codCategoria ");
            var lista = Connection.Query(sql.ToString(),
                transaction: Transaction);
            return lista;
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Combo entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Combo entity)
        {
            throw new NotImplementedException();
        }
    }
}
