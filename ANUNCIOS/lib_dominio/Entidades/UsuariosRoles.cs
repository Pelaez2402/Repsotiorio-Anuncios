using System.ComponentModel.DataAnnotations.Schema;

namespace lib_dominio.Entidades
{
    public class UsuariosRoles
    {
        public int UsuarioId{get; set;}
        public int RolId { get; set; }
        public DateTime FechaAsignacion { get; set; }
        public string? AsignadoPor { get; set; }
        public bool Activo { get; set; }


        [ForeignKey("Usuario")] public Usuarios? _Usuario { get; set; }
        [ForeignKey("Rol")] public Roles? _Rol { get; set; }
    }
}
