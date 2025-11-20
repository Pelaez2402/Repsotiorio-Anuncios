using lib_dominio.Entidades;
using System.Diagnostics.Metrics;

namespace lib_presentaciones.Interfaces
{
    public interface IFavoritosPresentacion
    {
        Task<List<Favoritos>> Listar();
        
        Task<Favoritos?> Guardar(Favoritos? entidad);
        Task<Favoritos?> Modificar(Favoritos? entidad);
        Task<Favoritos?> Borrar(Favoritos? entidad);
    }
}