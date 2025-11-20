using lib_dominio.Entidades;
using System.Diagnostics.Metrics;

namespace lib_presentaciones.Interfaces
{
    public interface IPlanesDePublicacionPresentacion
    {
        Task<List<PlanesDePublicacion>> Listar();
        
        Task<PlanesDePublicacion?> Guardar(PlanesDePublicacion? entidad);
        Task<PlanesDePublicacion?> Modificar(PlanesDePublicacion? entidad);
        Task<PlanesDePublicacion?> Borrar(PlanesDePublicacion? entidad);
    }
}
