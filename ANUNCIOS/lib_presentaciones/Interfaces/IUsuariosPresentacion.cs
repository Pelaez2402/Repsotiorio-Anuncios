using lib_dominio.Entidades;
using System.Diagnostics.Metrics;

namespace lib_presentaciones.Interfaces
{
    public interface IUsuariosRolesPresentacion
    {
        Task<List<UsuariosRoles>> Listar();
        Task<UsuariosRoles?> Guardar(UsuariosRoles? entidad);
        Task<UsuariosRoles?> Modificar(UsuariosRoles? entidad);
        Task<UsuariosRoles?> Borrar(UsuariosRoles? entidad);
    }
}
