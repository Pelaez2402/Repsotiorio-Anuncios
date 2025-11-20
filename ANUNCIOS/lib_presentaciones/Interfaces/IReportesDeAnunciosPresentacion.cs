using lib_dominio.Entidades;
using System.Diagnostics.Metrics;

namespace lib_presentaciones.Interfaces
{
    public interface IReportesDeAnunciosPresentacion
    {
        Task<List<ReportesDeAnuncios>> Listar();
        Task<ReportesDeAnuncios?> Guardar(ReportesDeAnuncios? entidad);
        Task<ReportesDeAnuncios?> Modificar(ReportesDeAnuncios? entidad);
        Task<ReportesDeAnuncios?> Borrar(ReportesDeAnuncios? entidad);
    }
}
