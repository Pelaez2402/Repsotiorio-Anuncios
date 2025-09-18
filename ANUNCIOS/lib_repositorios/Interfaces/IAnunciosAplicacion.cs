using lib_dominio.Entidades;

namespace lib_repositorios.Interfaces
{
    public interface IAnunciosAplicacion
    {
        void Configurar(string StringConexion);
        Anuncios? Borrar(Anuncios? entidad);
        Anuncios? Guardar(Anuncios? entidad);
        List<Anuncios> Listar();
        Anuncios? Modificar(Anuncios? entidad);
    }
}