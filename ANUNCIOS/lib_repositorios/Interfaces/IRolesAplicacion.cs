using lib_dominio.Entidades;

namespace lib_repositorios.Interfaces
{
    public interface IRolesAplicacion
    {
        void Configurar(string StringConexion);
        Roles? Borrar(Roles? entidad);
        Roles? Guardar(Roles? entidad);
        List<Roles> Listar();
        Roles? Modificar(Roles? entidad);
    }
}