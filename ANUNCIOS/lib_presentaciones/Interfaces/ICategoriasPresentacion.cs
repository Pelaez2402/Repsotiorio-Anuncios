using lib_dominio.Entidades;
using System.Diagnostics.Metrics;

namespace lib_presentaciones.Interfaces
{
    public interface ICategoriasPresentacion
    {
        Task<List<Categorias>> Listar();
        
        Task<Categorias?> Guardar(Categorias? entidad);
        Task<Categorias?> Modificar(Categorias? entidad);
        Task<Categorias?> Borrar(Categorias? entidad);
    }
}