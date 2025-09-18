using lib_dominio.Entidades;
using lib_repositorios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_repositorios.Implementaciones
{
    public class NotificacionesAplicacion : INotificacionAplicacion
    {
        private IConexion? IConexion = null;

        public NotificacionesAplicacion(IConexion iConexion) => this.IConexion = iConexion;

        public void Configurar(string StringConexion) => this.IConexion!.StringConexion = StringConexion;

        public Notificacion? Guardar(Notificacion? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id != 0) throw new Exception("lbYaSeGuardo");

            this.IConexion!.Notificaciones!.Add(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public Notificacion? Modificar(Notificacion? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id == 0) throw new Exception("lbNoSeGuardo");

            this.IConexion!.Notificaciones!.Update(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public Notificacion? Borrar(Notificacion? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id == 0) throw new Exception("lbNoSeGuardo");

            this.IConexion!.Notificaciones!.Remove(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public List<Notificacion> Listar() => this.IConexion!.Notificaciones!.Take(20).ToList();
    }
}
}
