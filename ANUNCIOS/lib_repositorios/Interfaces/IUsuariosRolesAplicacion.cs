using lib_dominio.Entidades;

namespace lib_repositorios.Interfaces
{
    public interface IUsuariosRoles
    {
    void Configurar(string StringConexion);
    UsuariosRoles? Borrar(UsuariosRoles? entidad);
    UsuariosRoles? Guardar(UsuariosRoles? entidad);
    List<UsuariosRoles> Listar();
    UsuariosRoles? Modificar(UsuariosRoles? entidad);
  }
}