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
            if (entity == null)
                throw new ArgumentNullException("entity");

            StringBuilder sql = new StringBuilder();
            sql.Append("Insert into GRP.tb_combo(nombre, descripcion, precio, descuento, ");
            sql.Append("estado, codCategoria, fechaCreacion, fechaModificacion)");
            sql.Append("values(@nombre, @descripcion, @precio, @precioVenta, @descuento, ");
            sql.Append("@estado, @categoria, @creacion)");
            sql.Append("SELECT SCOPE_IDENTITY()");

            entity.Id = Connection.ExecuteScalar<int>(
                sql.ToString(),
                param: new
                {
                    nombre = entity.Nombre,
                    descripcion = entity.Descripcion,
                    precio = entity.Precio,
                    precioVenta = entity.PrecioVenta,
                    descuento = entity.Descuento,
                    estado = 1,
                    categoria = entity.IdCategoria,
                    creacion = DateTime.Now
                },
                transaction: Transaction
            );
        }

        public Combo Get(int Id)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("Select codCombo as Id, Nombre, Descripcion, Precio, IsNull(Descuento,0) as Descuento, ");
            sql.Append("Cast(Precio - (Precio * (IsNull(Descuento,0)/100)) as decimal(10,2)) as PrecioVenta, ");
            sql.Append("Estado, codCategoria as IdCategoria, FechaCreacion, FechaModificacion ");
            sql.Append("From GRP.tb_combo ");
            sql.Append("Where codCombo = @IdCombo");
            var data = Connection.QueryFirstOrDefault<Combo>(sql.ToString(),
                param: new
                {
                    IdCombo = Id
                },
                transaction: Transaction);
            return data;
        }

        public IEnumerable<Combo> GetAll()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("Select A.codCombo as Id, A.Nombre, A.Descripcion, Precio, IsNull(Descuento,0) as Descuento, ");
            sql.Append("Cast(Precio - (Precio * (IsNull(Descuento,0)/100)) as decimal(10,2)) as PrecioVenta, ");
            sql.Append("A.Estado, A.codCategoria as IdCategoria, B.Nombre as Categoria, ");
            sql.Append("FechaCreacion, FechaModificacion ");
            sql.Append("From GRP.tb_combo A Inner Join GRP.tb_categoria B ");
            sql.Append("On A.codCategoria = B.codCategoria");
            var lista = Connection.Query<Combo>(sql.ToString(),
                transaction: Transaction);
            return lista;
        }

        public IEnumerable<dynamic> GetAllWithRelations()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("Select A.codCombo as Id, A.Nombre, A.Descripcion, Precio, PrecioVenta, Descuento, ");
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
            StringBuilder sql = new StringBuilder();
            sql.Append("Update GRP.tb_combo Set estado = 0 ");
            sql.Append("Where codCombo = @combo");

            Connection.Execute(
                sql.ToString(),
                transaction: Transaction
            );
        }

        public void Remove(Combo entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Combo entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            StringBuilder sql = new StringBuilder();
            sql.Append("Update GRP.tb_combo Set nombre = @nombre, descripcion = @descripcion, precio = @precio, ");
            sql.Append("descuento = @descuento, codCategoria = @categoria ");
            sql.Append("Where codCombo = @combo");

            Connection.Execute(
                sql.ToString(),
                param: new
                {
                    nombre = entity.Nombre,
                    descripcion = entity.Descripcion,
                    precio = entity.Precio,
                    descuento = entity.Descuento,
                    categoria = entity.IdCategoria,
                    combo = entity.Id
                },
                transaction: Transaction
            );
        }
    }
}