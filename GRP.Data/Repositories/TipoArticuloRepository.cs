using Dapper;
using GRP.Core;
using GRP.Data.Repositories.Contract;
using System;
using System.Collections.Generic;
using System.Data;

namespace GRP.Data.Repositories
{
    internal class TipoArticuloRepository : RepositoryBase, ITipoArticuloRepository
    {
        public TipoArticuloRepository(IDbTransaction transaction) :
            base(transaction)
        {
        }

        public void Add(TipoArticulo entity)
        {
            throw new NotImplementedException();
        }

        public TipoArticulo Get(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TipoArticulo> GetAll()
        {
            var lista = Connection.Query<TipoArticulo>("Select codTipoArticulo as Id, nombre as Nombre From GRP.tb_tipoArticulo",
                transaction: Transaction);
            return lista;
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(TipoArticulo entity)
        {
            throw new NotImplementedException();
        }

        public void Update(TipoArticulo entity)
        {
            throw new NotImplementedException();
        }
    }
}
