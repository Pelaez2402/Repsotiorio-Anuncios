using lib_dominio.Entidades;

namespace lib_repositorios.Interfaces
{
    public interface ISubcategoriasAplicacion
    {
        void Configurar(string StringConexion);
        Subcategorias? Borrar(Subcategorias? entidad);
        Subcategorias? Guardar(Subcategorias? entidad);
        List<Subcategorias> Listar();
        Subcategorias? Modificar(Subcategorias? entidad);
    }
}