

using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace lib_dominio.Entidades
{
    public class ImagenesAnuncios
    {
        public int Id { get; set; }
        public string? Url { get; set; }
        public int AnuncioId { get; set; }
        public int UsuarioId { get; set; }
        public string? Titulo { get; set; }
        public DateTime FechaSubida { get; set; }

        [ForeignKey("UsuarioId")] public Usuarios? _Usuario { get; set; }
        [ForeignKey("AnuncioId")] public Anuncios? _Anuncio { get; set; }

    }
}
