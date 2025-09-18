using Azure;
using lib_dominio.Entidades;

namespace lib_repositorios.Interfaces
{
    public interface IPagosAplicacion
    {
        void Configurar(string StringConexion);
        Pago? Borrar(Pago? entidad);
        Pago? Guardar(Pago? entidad);
        List<Pago> Listar();
        Pago? Modificar(Pago? entidad);
    }