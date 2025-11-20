using lib_dominio.Entidades;
using System.Diagnostics.Metrics;

namespace lib_presentaciones.Interfaces
{
    public interface IImagenesAnunciosPresentacion
    {
        Task<List<ImagenesAnuncios>> Listar();
        
        Task<ImagenesAnuncios?> Guardar(ImagenesAnuncios? entidad);
        Task<ImagenesAnuncios?> Modificar(ImagenesAnuncios? entidad);
        Task<ImagenesAnuncios?> Borrar(ImagenesAnuncios? entidad);
    }
}