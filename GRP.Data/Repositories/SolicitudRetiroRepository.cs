using Dapper;
using GRP.Core;
using GRP.Data.Repositories.Contract;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace GRP.Data.Repositories
{
    internal class SolicitudRetiroRepository : RepositoryBase, ISolicitudRetiroRepository
    {
        public SolicitudRetiroRepository(IDbTransaction transaction) 
            : base(transaction)
        {
        }

        public void Add(SolicitudRetiro entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            StringBuilder sql = new StringBuilder();
            sql.Append("Insert into GRP.tb_solicitudRetiro(fechaEnvio, comentario, codProyeccion, tipoSimulacion, estado)");
            sql.Append("values(@fechaEnvio, @comentario, @proyeccion, @tipo, @estado)");
            sql.Append("SELECT SCOPE_IDENTITY()");

            entity.Id = Connection.ExecuteScalar<int>(
                sql.ToString(),
                param: new
                {
                    fechaEnvio = DateTime.Now,
                    comentario = entity.Comentario,
                    proyeccion = entity.IdProyeccion,
                    tipo = entity.TipoSimulacion,
                    estado = 1
                },
                transaction: Transaction
            );
        }

        public SolicitudRetiro Get(int Id)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("Select codSolicitudRetiro as Id, FechaEnvio, comentario, ");
            sql.Append("codProyeccion as IdProyeccion, tipoSimulacion, estado ");
            sql.Append("From GRP.tb_solicitudRetiro ");
            sql.Append("Where codSolicitudRetiro = @IdSolicitud");
            var data = Connection.QueryFirstOrDefault<SolicitudRetiro>(sql.ToString(),
                param: new
                {
                    IdSolicitud = Id
                },
                transaction: Transaction);
            return data;
        }

        public IEnumerable<SolicitudRetiro> GetAll()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("Select codSolicitudRetiro as Id, FechaEnvio, comentario, ");
            sql.Append("codProyeccion as IdProyeccion, tipoSimulacion, estado ");
            sql.Append("From GRP.tb_solicitudRetiro");
            var lista = Connection.Query<SolicitudRetiro>(sql.ToString(),
                transaction: Transaction);
            return lista;
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(SolicitudRetiro entity)
        {
            throw new NotImplementedException();
        }

        public void Update(SolicitudRetiro entity)
        {
            throw new NotImplementedException();
        }
    }
}