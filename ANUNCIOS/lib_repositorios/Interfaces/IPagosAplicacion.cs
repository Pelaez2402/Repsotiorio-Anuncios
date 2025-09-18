using Azure;
using lib_dominio.Entidades;

namespace lib_repositorios.Interfaces
{
    public interface IPagosAplicacion
    {
        void Configurar(string StringConexion);
        Pagos? Borrar(Pagos? entidad);
        Pagos? Guardar(Pagos? entidad);
        List<Pagos> Listar();
        Pagos? Modificar(Pagos? entidad);
    }
}