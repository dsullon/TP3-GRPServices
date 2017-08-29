namespace GRP.Core
{
    public class Articulo: EntityBase
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string UnidadMedida { get; set; }
        public decimal Costo { get; set; }
        public TipoArticulo Tipo { get; set; }
    }
}
