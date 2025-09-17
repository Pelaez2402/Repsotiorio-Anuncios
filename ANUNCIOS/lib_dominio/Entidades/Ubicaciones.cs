using static System.Runtime.InteropServices.JavaScript.JSType;

namespace lib_dominio.Entidades
{
    public class Ubicaciones
    {
        public int  Id { get; set; }
        public string? Nombre { get; set; }
        public string? Direccion { get; set; }
        public string? Ciudad { get; set; }
        public string? Pais { get; set; }

        public List<Anuncios>? _Anuncio { get; set; } = new List<Anuncios>();
    }
}
