using lib_dominio.Entidades;

namespace lib_repositorios.Interfaces
{
    public interface IUbicacionesAplicacion
    {
        void Configurar(string StringConexion);
        Ubicacion? Borrar(Ubicacion? entidad);
        Ubicacion? Guardar(Ubicacion? entidad);
        List<Ubicacion> Listar();
        Ubicacion? Modificar(Ubicacion? entidad);
    }