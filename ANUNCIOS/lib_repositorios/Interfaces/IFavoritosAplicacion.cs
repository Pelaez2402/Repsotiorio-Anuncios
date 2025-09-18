using lib_dominio.Entidades;

namespace lib_repositorios.Interfaces
{
    public interface IFavoritosAplicacion
    {
        void Configurar(string StringConexion);
        Favoritos? Borrar(Favoritos? entidad);
        Favoritos? Guardar(Favoritos? entidad);
        List<Favoritos> Listar();
        Favoritos? Modificar(Favoritos? entidad);
    }
}