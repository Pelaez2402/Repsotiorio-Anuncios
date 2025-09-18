using lib_dominio.Entidades;

namespace lib_repositorios.Interfaces
{
    public interface IAnunciosSubcategoriasAplicacion
    {
        void Configurar(string StringConexion);
        AnunciosSubcategorias? Borrar(AnunciosSubcategorias? entidad);
        AnunciosSubcategorias? Guardar(AnunciosSubcategorias? entidad);
        List<AnunciosSubcategorias> Listar();
        AnunciosSubcategorias? Modificar(AnunciosSubcategorias? entidad);
    }
}