using lib_dominio.Entidades;

namespace lib_repositorios.Interfaces
{
    public interface IPlanesDePublicacionAplicacion
    {
        void Configurar(string StringConexion);
        PlanDePublicacion? Borrar(PlanDePublicacion? entidad);
        PlanDePublicacion? Guardar(PlanDePublicacion? entidad);
        List<PlanDePublicacion> Listar();
        PlanDePublicacion? Modificar(PlanDePublicacion? entidad);
    }