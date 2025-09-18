using System.ComponentModel.DataAnnotations.Schema;

namespace lib_dominio.Entidades
{
    public class UsuariosRoles
    {
        public int Id { get; set; }
        public int UsuarioId{get; set;}
        public int RolId { get; set; }
        public DateTime FechaAsignacion { get; set; }
        public string? AsignadoPor { get; set; }
        public bool Activo { get; set; }


        [ForeignKey("UsuarioId")] public Usuarios? _Usuario { get; set; }
        [ForeignKey("RolId")] public Roles? _Rol { get; set; }
    }
}
