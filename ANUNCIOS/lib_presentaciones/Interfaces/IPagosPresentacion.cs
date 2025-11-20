using lib_dominio.Entidades;
using System.Diagnostics.Metrics;

namespace lib_presentaciones.Interfaces
{
    public interface IPagosPresentacion
    {
        Task<List<Pagos>> Listar();
        
        Task<Pagos?> Guardar(Pagos? entidad);
        Task<Pagos?> Modificar(Pagos? entidad);
        Task<Pagos?> Borrar(Pagos? entidad);
    }
}