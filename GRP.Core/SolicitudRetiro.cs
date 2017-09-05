using System;
using System.Collections.Generic;

namespace GRP.Core
{
    public class SolicitudRetiro
    {
        public int Id { get; set; }
        public DateTime FechaEnvio { get; set; }
        public string Comentario { get; set; }
        public int IdProyeccion { get; set; }
        public int TipoSimulacion { get; set; }
        public bool Estado { get; set; }
        public IList<ComboSolicitudRetiro> Combos { get; set; }
    }
}