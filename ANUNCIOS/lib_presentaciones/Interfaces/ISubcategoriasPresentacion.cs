using lib_dominio.Entidades;
using System.Diagnostics.Metrics;

namespace lib_presentaciones.Interfaces
{
    public interface ISubcategoriasPresentacion
    {
        Task<List<Subcategorias>> Listar();
        
        Task<Subcategorias?> Guardar(Subcategorias? entidad);
        Task<Subcategorias?> Modificar(Subcategorias? entidad);
        Task<Subcategorias?> Borrar(Subcategorias? entidad);
    }
}
