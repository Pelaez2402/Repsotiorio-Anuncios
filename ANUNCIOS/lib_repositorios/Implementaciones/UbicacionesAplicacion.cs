using lib_dominio.Entidades;
using lib_repositorios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_repositorios.Implementaciones
{
    public class UbicacionesAplicacion : IUbicacionAplicacion
    {
        private IConexion? IConexion = null;

        public UbicacionesAplicacion(IConexion iConexion) => this.IConexion = iConexion;

        public void Configurar(string StringConexion) => this.IConexion!.StringConexion = StringConexion;

        public Ubicacion? Guardar(Ubicacion? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id != 0) throw new Exception("lbYaSeGuardo");

            this.IConexion!.Ubicaciones!.Add(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public Ubicacion? Modificar(Ubicacion? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id == 0) throw new Exception("lbNoSeGuardo");

            this.IConexion!.Ubicaciones!.Update(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public Ubicacion? Borrar(Ubicacion? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id == 0) throw new Exception("lbNoSeGuardo");

            this.IConexion!.Ubicaciones!.Remove(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public List<Ubicacion> Listar() => this.IConexion!.Ubicaciones!.Take(20).ToList();
    }
}
}
