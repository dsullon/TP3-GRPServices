using Dapper;
using GRP.Core;
using GRP.Data.Repositories.Contract;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace GRP.Data.Repositories
{
    internal class CategoriaRepository : RepositoryBase, ICategoriaRepository
    {
        public CategoriaRepository(IDbTransaction transaction) 
            : base(transaction)
        {
        }

        public void Add(Categoria entity)
        {
            throw new NotImplementedException();
        }

        public Categoria Get(int Id)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("Select codCategoria as Id, nombre, descripcion ");
            sql.Append("From GRP.tb_categoria ");
            sql.Append("Where codCategoria = @IdCategoria");
            var data = Connection.QueryFirstOrDefault<Categoria>(sql.ToString(), new { IdCategoria = Id },
                transaction: Transaction);
            return data;
        }

        public IEnumerable<Categoria> GetAll()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("Select codCategoria as Id, nombre, descripcion ");
            sql.Append("From GRP.tb_categoria");
            var lista = Connection.Query<Categoria>(sql.ToString(),
                transaction: Transaction);
            return lista;
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Categoria entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Categoria entity)
        {
            throw new NotImplementedException();
        }
    }
}
