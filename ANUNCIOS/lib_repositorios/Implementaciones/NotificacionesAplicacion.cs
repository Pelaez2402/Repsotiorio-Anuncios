using lib_dominio.Entidades;
using lib_repositorios.Interfaces;


namespace lib_repositorios.Implementaciones
{
    public class NotificacionesAplicacion : INotificacionesAplicacion
    {
        private IConexion? IConexion = null;

        public NotificacionesAplicacion(IConexion iConexion) => this.IConexion = iConexion;

        public void Configurar(string StringConexion) => this.IConexion!.StringConexion = StringConexion;

        public Notificaciones? Guardar(Notificaciones? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id != 0) throw new Exception("lbYaSeGuardo");

            this.IConexion!.Notificaciones!.Add(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public Notificaciones? Modificar(Notificaciones? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id == 0) throw new Exception("lbNoSeGuardo");

            this.IConexion!.Notificaciones!.Update(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public Notificaciones? Borrar(Notificaciones? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id == 0) throw new Exception("lbNoSeGuardo");

            this.IConexion!.Notificaciones!.Remove(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public List<Notificaciones> Listar() => this.IConexion!.Notificaciones!.Take(20).ToList();
    }
}

