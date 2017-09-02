using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRP.Core
{
    public class ProductoArticulo
    {
        public int IdProducto { get; set; }
        public int IdArticulo { get; set; }
        public decimal Costo { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Rendimiento { get; set; }
    }
}