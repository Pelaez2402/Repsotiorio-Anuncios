using lib_dominio.Entidades;

namespace lib_repositorios.Interfaces
{
    public interface IUsuariosAplicacion
    {
        void Configurar(string StringConexion);
        Usuarios? Borrar(Usuarios entidad);
        Usuarios? Guardar(Usuarios? entidad);
        List<Usuarios> Listar();
        Usuarios? Modificar(Usuarios? entidad);
    }
}