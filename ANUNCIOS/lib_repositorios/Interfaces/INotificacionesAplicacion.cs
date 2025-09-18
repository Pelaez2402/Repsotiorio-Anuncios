using lib_dominio.Entidades;

namespace lib_repositorios.Interfaces
{
    public interface INotificacionesAplicacion
    {
        void Configurar(string StringConexion);
        Notificacion? Borrar(Notificacion? entidad);
        Notificacion? Guardar(Notificacion? entidad);
        List<Notificacion> Listar();
        Notificacion? Modificar(Notificacion? entidad);
    }