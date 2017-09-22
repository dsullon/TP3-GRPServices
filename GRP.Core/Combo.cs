using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRP.Core
{
    public class Combo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public decimal Descuento { get; set; }
        public bool Estado { get; set; }
        public int IdCategoria { get; set; }
        public string Categoria { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }

        public IList<ComboProducto> Productos { get; set; }
    }
}