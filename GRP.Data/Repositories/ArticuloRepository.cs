using Dapper;
using GRP.Core;
using GRP.Data.Repositories.Contract;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace GRP.Data.Repositories
{
    internal class ArticuloRepository : RepositoryBase, IArticuloRepository
    {
        public ArticuloRepository(IDbTransaction transaction)
            : base(transaction)
        {
        }

        public void Add(Articulo entity)
        {
            throw new NotImplementedException();
        }

        public Articulo Get(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Articulo> GetAll()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("Select codArticulo as Id, nombre, descripcion, unidadMedida, ");
            sql.Append("costoXUM as Costo, codTipoArticulo as IdTipoArticulo ");
            sql.Append("From GRP.tb_Articulo");
            var lista = Connection.Query<Articulo>(sql.ToString(),
                transaction: Transaction);
            return lista;
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Articulo entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Articulo entity)
        {
            throw new NotImplementedException();
        }
    }
}