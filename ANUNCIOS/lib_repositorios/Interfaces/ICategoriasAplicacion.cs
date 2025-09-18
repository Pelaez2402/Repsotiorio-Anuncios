using lib_dominio.Entidades;

namespace lib_repositorios.Interfaces
{
    public interface ICategoriasAplicacion
    {
        void Configurar(string StringConexion);
        Categoria? Borrar(Categoria? entidad);
        Categoria? Guardar(Categoria? entidad);
        List<Categoria> Listar();
        Categoria? Modificar(Categoria? entidad);
    }
}