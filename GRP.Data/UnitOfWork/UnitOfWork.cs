using GRP.Data.Infrastructure;
using GRP.Data.Repositories;
using GRP.Data.Repositories.Contract;
using System;
using System.Data;

namespace GRP.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        #region . Variables .

        private IDbConnection _connection;
        private IDbTransaction _transaction;
        private ITipoArticuloRepository _tipoArticuloRepository;
        private IArticuloRepository _articuloRepository;
        private IProductoRepository _productoRepository;
        private ICategoriaRepository _categoriaRepository;
        private IInformacionNutricionalRepository _informacionNutricionalRepository;
        private IProductoArticuloRepository _productoArticuloRepository;
        private ISolicitudRetiroRepository _solicitudRetiroRepository;
        private IComboRepository _comboRepository;
        private IComboSolicitudRetiroRepository _comboSolicitudRetiroRepository;
        private bool _disposed;

        #endregion

        public UnitOfWork()
        {
            var con = new ConnectionFactory();
            _connection = con.GetConnection;
            _connection.Open();
            _transaction = _connection.BeginTransaction();
        }

        public ITipoArticuloRepository TipoArticuloRepository
        {
            get
            {
                return _tipoArticuloRepository ?? (_tipoArticuloRepository = new TipoArticuloRepository(_transaction));
            }
        }

        public IArticuloRepository ArticuloRepository
        {
            get
            {
                return _articuloRepository ?? (_articuloRepository = new ArticuloRepository(_transaction));
            }
        }

        public IProductoRepository ProductoRepository
        {
            get
            {
                return _productoRepository ?? (_productoRepository = new ProductoRepository(_transaction));
            }
        }

        public ICategoriaRepository CategoriaRepository
        {
            get
            {
                return _categoriaRepository ?? (_categoriaRepository = new CategoriaRepository(_transaction));
            }
        }

        public IInformacionNutricionalRepository InformacionNutricionalRepository
        {
            get
            {
                return _informacionNutricionalRepository ?? (_informacionNutricionalRepository = new InformacionNutricionalRepository(_transaction));
            }
        }

        public IProductoArticuloRepository ProductoArticuloRepository
        {
            get
            {
                return _productoArticuloRepository ?? (_productoArticuloRepository = new ProductoArticuloRepository(_transaction));
            }
        }

        public ISolicitudRetiroRepository SolicitudRetiroRepository
        {
            get
            {
                return _solicitudRetiroRepository ?? (_solicitudRetiroRepository = new SolicitudRetiroRepository(_transaction));
            }
        }

        public IComboRepository ComboRepository
        {
            get
            {
                return _comboRepository ?? (_comboRepository = new ComboRepository(_transaction));
            }
        }

        public IComboSolicitudRetiroRepository ComboSolicitudRetiroRepository
        {
            get
            {
                return _comboSolicitudRetiroRepository ?? (_comboSolicitudRetiroRepository = new ComboSolicitudRetiroRepository(_transaction));
            }
        }

        public void Commit()
        {
            try
            {
                _transaction.Commit();
            }
            catch
            {
                _transaction.Rollback();
                throw;
            }
            finally
            {
                _transaction.Dispose();
                _transaction = _connection.BeginTransaction();
                resetRepositories();
            }
        }

        #region . Dispose .

        private void resetRepositories()
        {
            _tipoArticuloRepository = null;
        }

        public void Dispose()
        {
            dispose(true);
            GC.SuppressFinalize(this);
        }

        private void dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    if (_transaction != null)
                    {
                        _transaction.Dispose();
                        _transaction = null;
                    }
                    if (_connection != null)
                    {
                        _connection.Dispose();
                        _connection = null;
                    }
                }
                _disposed = true;
            }
        }

        ~UnitOfWork()
        {
            dispose(false);
        }

        #endregion
    }
}