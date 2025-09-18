using lib_dominio.Entidades;

namespace lib_repositorios.Interfaces
{
    public interface IUbicacionesAplicacion
    {
        void Configurar(string StringConexion);
        Ubicaciones? Borrar(Ubicaciones? entidad);
        Ubicaciones? Guardar(Ubicaciones? entidad);
        List<Ubicaciones> Listar();
        Ubicaciones? Modificar(Ubicaciones? entidad);
    }
}