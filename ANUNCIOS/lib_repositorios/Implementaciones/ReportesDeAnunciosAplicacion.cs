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

            this.IConexion!.ReportesDeAnuncios!.Add(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public ReportesDeAnuncios? Modificar(ReportesDeAnuncios? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id == 0) throw new Exception("lbNoSeGuardo");

            this.IConexion!.ReportesDeAnuncios!.Update(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public ReportesDeAnuncios? Borrar(ReportesDeAnuncios? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id == 0) throw new Exception("lbNoSeGuardo");

            this.IConexion!.ReportesDeAnuncios!.Remove(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public List<ReportesDeAnuncios> Listar() => this.IConexion!.ReportesDeAnuncios!.Take(20).ToList();
    }

    
}

