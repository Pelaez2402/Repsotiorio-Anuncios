using lib_dominio.Entidades;
namespace lib_repositorios.Interfaces
{
    public interface IReportesDeAnunciosAplicacion
    {
        void Configurar(string StringConexion);
        ReportesDeAnuncios? Borrar(ReportesDeAnuncios? entidad);
        ReportesDeAnuncios? Guardar(ReportesDeAnuncios? entidad);
        List<ReportesDeAnuncios> Listar();
           ReportesDeAnuncios? Modificar(ReportesDeAnuncios? entidad);
   }
}