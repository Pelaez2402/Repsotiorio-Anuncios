using lib_dominio.Entidades;
using lib_repositorios.Interfaces;


namespace lib_repositorios.Implementaciones
{
    public class ReportesDeAnunciosAplicacion : IReportesDeAnunciosAplicacion
    {
        private IConexion? IConexion = null;

        public ReportesDeAnunciosAplicacion(IConexion iConexion) => this.IConexion = iConexion;

        public void Configurar(string StringConexion) => this.IConexion!.StringConexion = StringConexion;

        public ReportesDeAnuncios? Guardar(ReportesDeAnuncios? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id != 0) throw new Exception("lbYaSeGuardo");
            if (entidad.AnuncioId == 0)
                throw new Exception("lbAnuncioNoValido");
            if (entidad.UsuarioId == 0)
                throw new Exception("lbUsuarioNoValido");
            if (string.IsNullOrWhiteSpace(entidad.Motivo))
                throw new Exception("lbSinMotivo");
            
            this.IConexion!.ReportesDeAnuncios!.Add(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public ReportesDeAnuncios? Modificar(ReportesDeAnuncios? entidad)
        {
            if(entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id == 0) throw new Exception("lbNoSeGuardo");
            var entidadExistente = this.IConexion!.ReportesDeAnuncios!.Find(entidad.Id);
            if (entidadExistente == null)
                throw new Exception("lbEntidadNoEncontrada");

            entidadExistente.Estado = entidad.Estado;
            entidadExistente.Motivo = entidad.Motivo;
            entidadExistente.FechaReporte = DateTime.Now;
          

            this.IConexion!.ReportesDeAnuncios!.Update(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public ReportesDeAnuncios? Borrar(ReportesDeAnuncios? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id == 0) throw new Exception("lbNoSeGuardo");
            if (entidad.Estado == "PENDIENTE")
                throw new Exception("lbReportePendiente");
            this.IConexion!.ReportesDeAnuncios!.Remove(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public List<ReportesDeAnuncios> Listar() => this.IConexion!.ReportesDeAnuncios!.Take(20).ToList();
    }

    
}

