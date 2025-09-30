using lib_dominio.Entidades;
using System.Diagnostics.Metrics;

namespace lib_repositorios.Interfaces
{
    public interface IAnunciosAplicacion
    {
        void Configurar(string StringConexion);
        List<Anuncios> PorTitulo(Anuncios? entidad);
        Anuncios? Borrar(Anuncios? entidad);
        Anuncios? Guardar(Anuncios? entidad);
        List<Anuncios> Listar();
        Anuncios? Modificar(Anuncios? entidad);
    }
}