using lib_dominio.Entidades;

namespace lib_repositorios.Interfaces
{
    public interface INotificacionesAplicacion
    {
        void Configurar(string StringConexion);
        Notificaciones? Borrar(Notificaciones? entidad);
        Notificaciones? Guardar(Notificaciones? entidad);
        List<Notificaciones> Listar();
        Notificaciones? Modificar(Notificaciones? entidad);
    }
}