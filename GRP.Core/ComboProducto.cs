using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRP.Core
{
    public class ComboProducto
    {
        public int IdCombo { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public bool EsPrincipal { get; set; }
    }
}