using lib_dominio.Entidades;
using System.Diagnostics.Metrics;

namespace lib_presentaciones.Interfaces
{
    public interface INotificacionesPresentacion
    {
        Task<List<Notificaciones>> Listar();
        
        Task<Notificaciones?> Guardar(Notificaciones? entidad);
        Task<Notificaciones?> Modificar(Notificaciones? entidad);
        Task<Notificaciones?> Borrar(Notificaciones? entidad);
    }
}