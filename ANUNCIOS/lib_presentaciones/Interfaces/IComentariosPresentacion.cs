using lib_dominio.Entidades;
using System.Diagnostics.Metrics;

namespace lib_presentaciones.Interfaces
{
    public interface IComentariosPresentacion
    {
        Task<List<Comentarios>> Listar();
        
        Task<Comentarios?> Guardar(Comentarios? entidad);
        Task<Comentarios?> Modificar(Comentarios? entidad);
        Task<Comentarios?> Borrar(Comentarios? entidad);
    }
}