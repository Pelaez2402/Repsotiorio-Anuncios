using lib_dominio.Entidades;

namespace lib_repositorios.Interfaces
{
    public interface IAnunciosAplicacion
    {
        void Configurar(string StringConexion);
        Anuncio? Borrar(Anuncio? entidad);
        Anuncio? Guardar(Anuncio? entidad);
        List<Anuncio> Listar();
        Anuncio? Modificar(Anuncio? entidad);
    }