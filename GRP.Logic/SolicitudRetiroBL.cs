using GRP.Core;
using GRP.Data.UnitOfWork;
using System.Collections.Generic;

namespace GRP.Logic
{
    public class SolicitudRetiroBL
    {
        public static IEnumerable<SolicitudRetiro> GetAll()
        {
            IEnumerable<SolicitudRetiro> lista;
            using (var uow = new UnitOfWork())
            {
                lista = uow.SolicitudRetiroRepository.GetAll();
            };
            return lista;
        }

        public static SolicitudRetiro Get(int id)
        {
            SolicitudRetiro solicitud;
            using (var uow = new UnitOfWork())
            {
                solicitud = uow.SolicitudRetiroRepository.Get(id);
            }
            return solicitud;
        }

        public static void Add(SolicitudRetiro solicitud)
        {
            using (var uow = new UnitOfWork())
            {
                uow.SolicitudRetiroRepository.Add(solicitud);
                ComboSolicitudRetiro combo;
                for (int i = 0; i < solicitud.Combos.Count; i++)
                {
                    combo = solicitud.Combos[i];
                    combo.IdSolicitud = solicitud.Id;
                    uow.ComboSolicitudRetiroRepository.Add(combo);
                }
                uow.Commit();
            }
        }
    }
}