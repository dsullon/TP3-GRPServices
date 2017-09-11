using System.Collections.Generic;

namespace GRP.Core
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Umbral { get; set; }
        public decimal Precio { get; set; }
        public decimal Costo { get; set; }
        public string Elaboracion { get; set; }
        public int Porciones { get; set; }
        public int IdCategoria { get; set; }
        public string Categoria { get; set; }
        public IList<ProductoArticulo> Insumos { get; set; }
    }
}