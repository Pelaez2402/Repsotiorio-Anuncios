using lib_dominio.Entidades;

namespace lib_repositorios.Interfaces
{
    public interface IAnunciosSubcategoriasAplicacion
    {
        void Configurar(string StringConexion);
        AnuncioSubcategoria? Borrar(AnuncioSubcategoria? entidad);
        AnuncioSubcategoria? Guardar(AnuncioSubcategoria? entidad);
        List<AnuncioSubcategoria> Listar();
        AnuncioSubcategoria? Modificar(AnuncioSubcategoria? entidad);
    }