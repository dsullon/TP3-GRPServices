using GRP.Data.Repositories.Contract;
using System;

namespace GRP.Data.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        ITipoArticuloRepository TipoArticuloRepository { get; }
        IArticuloRepository ArticuloRepository { get; }
        IProductoRepository ProductoRepository { get; }
        ICategoriaRepository CategoriaRepository { get; }
        IInformacionNutricionalRepository InformacionNutricionalRepository { get; }
        IProductoArticuloRepository ProductoArticuloRepository { get; }
        ISolicitudRetiroRepository SolicitudRetiroRepository { get; }
        IComboRepository ComboRepository { get; }
        IComboSolicitudRetiroRepository ComboSolicitudRetiroRepository { get; }
        void Commit();
    }
}
