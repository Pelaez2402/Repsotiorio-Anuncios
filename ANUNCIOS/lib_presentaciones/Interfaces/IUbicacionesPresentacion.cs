using lib_dominio.Entidades;
using System.Diagnostics.Metrics;

namespace lib_presentaciones.Interfaces
{
    public interface IUbicacionesPresentacion
    {
        Task<List<Ubicaciones>> Listar();
        Task<Ubicaciones?> Guardar(Ubicaciones? entidad);
        Task<Ubicaciones?> Modificar(Ubicaciones? entidad);
        Task<Ubicaciones?> Borrar(Ubicaciones? entidad);
    }
}
