using lib_dominio.Entidades;
using System.Diagnostics.Metrics;

namespace lib_presentaciones.Interfaces
{
    public interface IImagenesAnunciosPresentacion
    {
        Task<List<Anuncios>> Listar();
        Task<List<Anuncios>> PorTitulo(Anuncios? entidad);
        Task<Anuncios?> Guardar(Anuncios? entidad);
        Task<Anuncios?> Modificar(Anuncios? entidad);
        Task<Anuncios?> Borrar(Anuncios? entidad);
    }
}