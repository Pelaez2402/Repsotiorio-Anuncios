using lib_dominio.Entidades;

namespace lib_repositorios.Interfaces
{
    public interface IComentariosAplicacion
    {
        void Configurar(string StringConexion);
        Comentarios? Borrar(Comentarios? entidad);
        Comentarios? Guardar(Comentarios? entidad);
        List<Comentarios> Listar();
        Comentarios? Modificar(Comentarios? entidad);
    }
}