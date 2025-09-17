


using System.ComponentModel.DataAnnotations.Schema;

namespace lib_dominio.Entidades
{
    public class ReportesDeAnuncios
    {
        public int Id { get; set; }
        public string? Motivo { get; set; }
        public DateTime FechaReporte { get; set; }    
        public int UsuarioId { get; set; }
        public int AnuncioId { get; set; }
        public string? Estado { get; set; }

        [ForeignKey("Usuario")] public Usuarios? _Usuario { get; set; }
        [ForeignKey("Anuncio")] public Anuncios? _Anuncio { get; set; }
    }
}
