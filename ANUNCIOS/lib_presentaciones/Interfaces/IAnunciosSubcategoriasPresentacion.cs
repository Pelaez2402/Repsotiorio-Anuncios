using lib_dominio.Entidades;
using System.Diagnostics.Metrics;

namespace lib_presentaciones.Interfaces
{
    public interface IAnunciosSubcategoriasPresentacion
    {
        Task<List<AnunciosSubcategorias>> Listar();
       
        Task<AnunciosSubcategorias?> Guardar(AnunciosSubcategorias? entidad);
        Task<AnunciosSubcategorias?> Modificar(AnunciosSubcategorias? entidad);
        Task<AnunciosSubcategorias?> Borrar(AnunciosSubcategorias? entidad);
    }
}