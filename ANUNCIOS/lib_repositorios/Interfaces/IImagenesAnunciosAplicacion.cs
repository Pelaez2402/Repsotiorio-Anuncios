using lib_dominio.Entidades;

namespace lib_repositorios.Interfaces
{
    public interface IImagenesAnunciosAplicacion
    {
        void Configurar(string StringConexion);
        ImagenAnuncio? Borrar(ImagenAnuncio? entidad);
        ImagenAnuncio? Guardar(ImagenAnuncio? entidad);
        List<ImagenAnuncio> Listar();
        ImagenAnuncio? Modificar(ImagenAnuncio? entidad);
    }