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

        public IEnumerable<dynamic> GetUmbral()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("Select a.codArticulo as Id, nombre as Nombre, Descripcion, CostoXUM, ");
            sql.Append("TipoVariacion, FechaAlerta, NuevoCosto From[GRP].[tb_articulo] a ");
            sql.Append("Inner Join[GRP].[tb_alertasCambiosCostos] al on a.CodArticulo = al.codArticulo ");
            sql.Append("Where al.estado = 'Pendiente'");
            var lista = Connection.Query(sql.ToString(),
                transaction: Transaction);
            return lista;
        }

        public dynamic GetUmbralPerId(int Id)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("Select a.codArticulo as Id, nombre as Nombre, Descripcion, CostoXUM, ");
            sql.Append("TipoVariacion, FechaAlerta, NuevoCosto From[GRP].[tb_articulo] a ");
            sql.Append("Inner Join[GRP].[tb_alertasCambiosCostos] al on a.CodArticulo = al.codArticulo ");
            sql.Append("Where al.estado = 'Pendiente' and a.codArticulo = @IdProducto");
            var data = Connection.QueryFirstOrDefault<dynamic>(sql.ToString(),
                param: new
                {
                    IdProducto = Id
                },
                transaction: Transaction);
            return data;
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