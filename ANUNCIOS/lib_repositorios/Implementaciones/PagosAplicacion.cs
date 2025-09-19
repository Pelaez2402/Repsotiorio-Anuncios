using lib_repositorios.Interfaces;
using lib_dominio.Entidades;


namespace lib_repositorios.Implementaciones
{
    public class PagosAplicacion : IPagosAplicacion
    {
        private IConexion? IConexion = null;

        public PagosAplicacion(IConexion iConexion) => this.IConexion = iConexion;

        public void Configurar(string StringConexion) => this.IConexion!.StringConexion = StringConexion;

        public Pagos? Guardar(Pagos? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id != 0) throw new Exception("lbYaSeGuardo");
            var plan = this.IConexion!.PlanesDePublicacion!.FirstOrDefault(p => p.Id == entidad.PlanId);
            if (plan == null)
                throw new Exception("lbElplanEspecificadoNoExiste");
            if (string.IsNullOrWhiteSpace(entidad.MetodoPago))
                throw new Exception("lbMetodoPagoNoEspecificado");
            if (decimal.IsNegative(entidad.Monto))
                throw new Exception("lbMontoErroneo");
            if (entidad.Monto == 0)
            {
                entidad.Estado = "CANCELADO";
                throw new Exception("lbPagoCancelado");
            }

            this.IConexion!.Pagos!.Add(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public Pagos? Modificar(Pagos? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id == 0) throw new Exception("lbNoSeGuardo");
            var entidadExistente = this.IConexion!.Pagos!.Find(entidad.Id);
            if (entidadExistente == null)
                throw new Exception("lbEntidadNoEncontrada");

            entidadExistente.Estado = entidad.Estado;
            entidadExistente.MetodoPago = entidad.MetodoPago;
            entidadExistente.FechaPago = DateTime.Now;
            entidadExistente.Monto = entidad.Monto;
            this.IConexion!.Pagos!.Update(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public Pagos? Borrar(Pagos? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id == 0) throw new Exception("lbNoSeGuardo");
            if (entidad.Estado.Equals("PENDIENTE"))
                throw new Exception("lbPagoPendiente");
            this.IConexion!.Pagos!.Remove(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public List<Pagos> Listar() => this.IConexion!.Pagos!.Take(20).ToList();
    }
}

