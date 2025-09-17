

using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace lib_dominio.Entidades
{
    public class Notificaciones
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public string? Titulo { get; set; }
        public string? Mensaje { get; set; }
        public DateTime FechaCreacion { get; set; }
        public bool Leida { get; set; }
        public string? UrlDestino { get; set; }

        [ForeignKey("Usuario")] public Usuarios? _Usuario { get; set; }
    }
}
