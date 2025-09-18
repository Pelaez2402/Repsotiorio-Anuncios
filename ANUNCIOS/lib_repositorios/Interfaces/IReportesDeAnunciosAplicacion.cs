using lib_dominio.Entidades;

namespace lib_repositorios.Interfaces
{
    void Configurar(string StringConexion);
    ReporteDeAnuncio? Borrar(ReporteDeAnuncio? entidad);
    ReporteDeAnuncio? Guardar(ReporteDeAnuncio? entidad);
    List<ReporteDeAnuncio> Listar();
    ReporteDeAnuncio? Modificar(ReporteDeAnuncio? entidad);
}