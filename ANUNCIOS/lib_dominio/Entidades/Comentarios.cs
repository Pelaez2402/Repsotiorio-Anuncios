
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace lib_dominio.Entidades
{
    public class Comentarios
    {
        public int Id { get; set; }
       public string? Contenido { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int UsuarioId { get; set; }
        public int AnuncioId { get; set; }
        public int ComentarioPadreId { get; set; }
        public bool Activo { get; set; }

        [ForeignKey("Usuario")] public Usuarios? _Usuario { get; set; }
        [ForeignKey("Anuncio")] public Anuncios? _Anuncio { get; set; }
        [ForeignKey("ComentarioPadreId")] public Comentarios? ComentarioPadre { get; set; }
        public List<Comentarios> Respuestas { get; set; } = new List<Comentarios>();


    }
}
