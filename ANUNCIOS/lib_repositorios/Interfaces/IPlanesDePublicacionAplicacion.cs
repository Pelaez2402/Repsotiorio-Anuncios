using lib_dominio.Entidades;

namespace lib_repositorios.Interfaces
{
    public interface IPlanesDePublicacionAplicacion
    {
        void Configurar(string StringConexion);
        PlanesDePublicacion? Borrar(PlanesDePublicacion? entidad);
        PlanesDePublicacion? Guardar(PlanesDePublicacion? entidad);
        List<PlanesDePublicacion> Listar();
        PlanesDePublicacion? Modificar(PlanesDePublicacion? entidad);
    }
}