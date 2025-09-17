using System.ComponentModel.DataAnnotations.Schema;
using System.Xml;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace lib_dominio.Entidades
{
    public class Usuarios
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Correo { get; set; }
        public string? Contraseña { get; set; }
        public string? Telefono { get; set; }
        public DateTime FechaRegistro { get; set; }

        public List<UsuariosRoles> UsuariosRoles { get; set; } = new List<UsuariosRoles>();
        public List<Anuncios> Anuncios { get; set; } = new List<Anuncios>();
        public List<Comentarios> Comentarios { get; set; } = new List<Comentarios>();
        public List<ImagenesAnuncios> ImagenesAnuncios { get; set; } = new List<ImagenesAnuncios>();
        public List<Favoritos> Favoritos { get; set; } = new List<Favoritos>();
        public List<ReportesDeAnuncios> ReportesDeAnuncios { get; set; } = new List<ReportesDeAnuncios>();
        public List<Pagos> Pagos { get; set; } = new List<Pagos>();
        public List<Notificaciones> Notificaciones{ get; set; } = new List<Notificaciones>();




    }
}
