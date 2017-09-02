namespace GRP.Core
{
    public class Articulo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string UnidadMedida { get; set; }
        public decimal Costo { get; set; }
        public int  IdTipoArticulo { get; set; }
    }
}
