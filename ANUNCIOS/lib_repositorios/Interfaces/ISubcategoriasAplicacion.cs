using lib_dominio.Entidades;

namespace lib_repositorios.Interfaces
{
    public interface ISubcategoriasAplicacion
    {
        void Configurar(string StringConexion);
        Subcategoria? Borrar(Subcategoria? entidad);
        Subcategoria? Guardar(Subcategoria? entidad);
        List<Subcategoria> Listar();
        Subcategoria? Modificar(Subcategoria? entidad);
    }