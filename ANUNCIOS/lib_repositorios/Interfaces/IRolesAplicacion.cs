using lib_dominio.Entidades;

namespace lib_repositorios.Interfaces
{
    public interface IRolesAplicacion
    {
        void Configurar(string StringConexion);
        Rol? Borrar(Rol? entidad);
        Rol? Guardar(Rol? entidad);
        List<Rol> Listar();
        Rol? Modificar(Rol? entidad);
    }