using lib_dominio.Entidades;
using System.Diagnostics.Metrics;

namespace lib_presentaciones.Interfaces
{
    public interface IUsuariosPresentacion
    {
        Task<List<Usuarios>> Listar();
        Task<Usuarios?> Guardar(Usuarios? entidad);
        Task<Usuarios?> Modificar(Usuarios? entidad);
        Task<Usuarios?> Borrar(Usuarios? entidad);
    }
}
