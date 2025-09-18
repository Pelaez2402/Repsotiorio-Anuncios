using lib_dominio.Entidades;

namespace lib_repositorios.Interfaces
{
    public interface IUsuariosAplicacion
    {
        void Configurar(string StringConexion);
        Usuario? Borrar(Usuario? entidad);
        Usuario? Guardar(Usuario? entidad);
        List<Usuario> Listar();
        Usuario? Modificar(Usuario? entidad);
    }