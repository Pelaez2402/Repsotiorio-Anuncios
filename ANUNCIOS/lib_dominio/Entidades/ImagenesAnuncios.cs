

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

        [ForeignKey("Usuario")] public Usuarios? _Usuario { get; set; }
        [ForeignKey("Anuncio")] public Anuncios? _Anuncio { get; set; }

    }
}
