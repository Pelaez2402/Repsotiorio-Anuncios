using lib_dominio.Entidades;
using lib_repositorios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_repositorios.Implementaciones
{
    public class ReportesDeAnunciosAplicacion : IReporteDeAnuncioAplicacion
    {
        private IConexion? IConexion = null;

        public ReportesDeAnunciosAplicacion(IConexion iConexion) => this.IConexion = iConexion;

        public void Configurar(string StringConexion) => this.IConexion!.StringConexion = StringConexion;

        public ReporteDeAnuncio? Guardar(ReporteDeAnuncio? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id != 0) throw new Exception("lbYaSeGuardo");

            this.IConexion!.ReportesDeAnuncios!.Add(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public ReporteDeAnuncio? Modificar(ReporteDeAnuncio? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id == 0) throw new Exception("lbNoSeGuardo");

            this.IConexion!.ReportesDeAnuncios!.Update(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public ReporteDeAnuncio? Borrar(ReporteDeAnuncio? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id == 0) throw new Exception("lbNoSeGuardo");

            this.IConexion!.ReportesDeAnuncios!.Remove(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public List<ReporteDeAnuncio> Listar() => this.IConexion!.ReportesDeAnuncios!.Take(20).ToList();
    }
}
}
