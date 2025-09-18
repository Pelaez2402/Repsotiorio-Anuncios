using lib_dominio.Entidades;

namespace lib_repositorios.Interfaces
{
    public interface ICategoriasAplicacion
    {
        void Configurar(string StringConexion);
        Categorias? Borrar(Categorias? entidad);
        Categorias? Guardar(Categorias? entidad);
        List<Categorias> Listar();
        Categorias? Modificar(Categorias? entidad);
    }
}