using Dapper;
using GRP.Core;
using GRP.Data.Repositories.Contract;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace GRP.Data.Repositories
{
    internal class InformacionNutricionalRepository : RepositoryBase, IInformacionNutricionalRepository
    {
        public InformacionNutricionalRepository(IDbTransaction transaction) 
            : base(transaction)
        {
        }

        public void Add(InformacionNutricional entity)
        {
            throw new NotImplementedException();
        }

        public InformacionNutricional Get(int Id)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("Select codArticulo as IdArticulo, calorias, grasas, proteinas, carbohidratos ");
            sql.Append("From GRP.tb_infnutricional ");
            sql.Append("Where codArticulo = @IdArticulo");
            var data = Connection.QueryFirstOrDefault<InformacionNutricional>(sql.ToString(), new { IdArticulo = Id },
                transaction: Transaction);
            return data;
        }

        public IEnumerable<InformacionNutricional> GetAll()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("Select codArticulo as IdArticulo, calorias, grasas, proteinas, carbohidratos ");
            sql.Append("From GRP.tb_infnutricional ");
            var lista = Connection.Query<InformacionNutricional>(sql.ToString(),
                transaction: Transaction);
            return lista;
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(InformacionNutricional entity)
        {
            throw new NotImplementedException();
        }

        public void Update(InformacionNutricional entity)
        {
            throw new NotImplementedException();
        }
    }
}
