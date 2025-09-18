using lib_dominio.Entidades;

namespace lib_repositorios.Interfaces
{
    public interface IImagenesAnunciosAplicacion
    {
        void Configurar(string StringConexion);
        ImagenesAnuncios? Borrar(ImagenesAnuncios? entidad);
        ImagenesAnuncios? Guardar(ImagenesAnuncios? entidad);
        List<ImagenesAnuncios> Listar();
        ImagenesAnuncios? Modificar(ImagenesAnuncios? entidad);
    }
}