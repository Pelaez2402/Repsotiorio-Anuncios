namespace lib_dominio.Entidades
{
    public class PlanesDePublicacion
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Duracion { get; set; }
        public string? Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public byte Activo { get; set; }

        public List<Anuncios>? _Anuncio { get; set; } = new List<Anuncios>();
    }
}
