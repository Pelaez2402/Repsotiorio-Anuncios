using lib_dominio.Entidades;

namespace lib_repositorios.Interfaces
{
    public interface IComentariosAplicacion
    {
        void Configurar(string StringConexion);
        Comentario? Borrar(Comentario? entidad);
        Comentario? Guardar(Comentario? entidad);
        List<Comentario> Listar();
        Comentario? Modificar(Comentario? entidad);
    }