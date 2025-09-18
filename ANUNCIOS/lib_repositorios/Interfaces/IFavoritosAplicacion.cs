using lib_dominio.Entidades;

namespace lib_repositorios.Interfaces
{
    public interface IFavoritosAplicacion
    {
        void Configurar(string StringConexion);
        Favorito? Borrar(Favorito? entidad);
        Favorito? Guardar(Favorito? entidad);
        List<Favorito> Listar();
        Favorito? Modificar(Favorito? entidad);
    }