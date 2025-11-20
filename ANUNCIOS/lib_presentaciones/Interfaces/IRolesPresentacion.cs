using lib_dominio.Entidades;
using System.Diagnostics.Metrics;

namespace lib_presentaciones.Interfaces
{
    public interface IRolesPresentacion
    {
        Task<List<Roles>> Listar();
        
        Task<Roles?> Guardar(Roles? entidad);
        Task<Roles?> Modificar(Roles? entidad);
        Task<Roles?> Borrar(Roles? entidad);
    }
}
