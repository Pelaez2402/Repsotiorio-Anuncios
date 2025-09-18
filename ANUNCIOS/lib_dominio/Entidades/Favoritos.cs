
using System.ComponentModel.DataAnnotations.Schema;

namespace lib_dominio.Entidades
{
    public class Favoritos
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; } 
        public int AnuncioId { get; set; }
        public DateTime FechaAgregado { get; set; }
        public string? Notas { get; set; }
        public bool Activo { get; set; }

        [ForeignKey("UsuarioId")] public Usuarios? _Usuario { get; set; }
        [ForeignKey("AnuncioId")] public Anuncios? _Anuncio { get; set; }
    }
}
