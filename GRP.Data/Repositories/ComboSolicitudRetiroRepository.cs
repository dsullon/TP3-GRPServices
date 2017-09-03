using Dapper;
using GRP.Core;
using GRP.Data.Repositories.Contract;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace GRP.Data.Repositories
{
    internal class ComboSolicitudRetiroRepository : RepositoryBase, IComboSolicitudRetiroRepository
    {
        public ComboSolicitudRetiroRepository(IDbTransaction transaction) 
            : base(transaction)
        {
        }

        public void Add(ComboSolicitudRetiro entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            StringBuilder sql = new StringBuilder();
            sql.Append("Insert into GRP.tb_comboSolicitudRetiro(codSolicitudRetiro, codCombo, tipoItemSolicitud)");
            sql.Append("values(@solicitud, @combo, @tipo)");
            sql.Append("SELECT SCOPE_IDENTITY()");

            Connection.Execute(
                sql.ToString(),
                param: new
                {
                    solicitud = entity.IdSolicitud,
                    combo = entity.IdCombo,
                    tipo = entity.Tipo
                },
                transaction: Transaction
            );
        }

        public ComboSolicitudRetiro Get(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ComboSolicitudRetiro> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(ComboSolicitudRetiro entity)
        {
            throw new NotImplementedException();
        }

        public void Update(ComboSolicitudRetiro entity)
        {
            throw new NotImplementedException();
        }
    }
}