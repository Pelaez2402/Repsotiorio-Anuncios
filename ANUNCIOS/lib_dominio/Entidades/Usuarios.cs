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

        public List<UsuariosRoles>? _UsuarioRol { get; set; } = new List<UsuariosRoles>();
        public List<Anuncios>? _Anuncio { get; set; } = new List<Anuncios>();

    }
}
