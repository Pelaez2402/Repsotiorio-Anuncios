using lib_dominio.Entidades;
using lib_repositorios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_repositorios.Implementaciones
{
    public class PlanesDePublicacionAplicacion : IPlanDePublicacionAplicacion
    {
        private IConexion? IConexion = null;

        public PlanesDePublicacionAplicacion(IConexion iConexion) => this.IConexion = iConexion;

        public void Configurar(string StringConexion) => this.IConexion!.StringConexion = StringConexion;

        public PlanDePublicacion? Guardar(PlanDePublicacion? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id != 0) throw new Exception("lbYaSeGuardo");

            this.IConexion!.PlanesDePublicacion!.Add(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public PlanDePublicacion? Modificar(PlanDePublicacion? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id == 0) throw new Exception("lbNoSeGuardo");

            this.IConexion!.PlanesDePublicacion!.Update(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public PlanDePublicacion? Borrar(PlanDePublicacion? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id == 0) throw new Exception("lbNoSeGuardo");

            this.IConexion!.PlanesDePublicacion!.Remove(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public List<PlanDePublicacion> Listar() => this.IConexion!.PlanesDePublicacion!.Take(20).ToList();
    }
}
}
