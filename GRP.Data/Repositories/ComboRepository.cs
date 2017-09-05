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
            sql.Append("Select A.codCombo as Id, A.Nombre, A.Descripcion, Precio, Descuento, ");
            sql.Append("A.Estado, A.codCategoria as IdCategoria, B.Nombre as Categoria, ");
            sql.Append("FechaCreacion, FechaModificacion, C.MontoProyectado, C.PorcentajeAporte, ");
            sql.Append("D.MetaAnual, C.codProyeccion as IdProyeccion, ");
            sql.Append("IsNull((Select SUM((z.cantidad * z.precio)-z.descuento) From GRP.tb_detalleventa Z ");
            sql.Append("Inner Join GRP.tb_venta Y On Z.codVenta = Y.codventa Where Z.codCombo = A.codCombo ");
            sql.Append("And Year(Y.fechaVenta) = D.periodo),0) As VentaPeriodo ");
            sql.Append("From GRP.tb_combo A Inner Join GRP.tb_categoria B ");
            sql.Append("On A.codCategoria = B.codCategoria Inner Join GRP.tb_proyeccioncombo C ");
            sql.Append("On A.codCombo = C.codCombo Inner Join GRP.tb_proyeccion D ");
            sql.Append("On C.codProyeccion = D.codProyeccion And D.estado = 1");
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
