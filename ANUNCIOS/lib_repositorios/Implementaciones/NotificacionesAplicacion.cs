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
            if (entidad.UsuarioId == 0)
                throw new Exception("lbUsuarioNoValido");
            if (string.IsNullOrWhiteSpace(entidad.Mensaje))
                throw new Exception("lbNotificacionSinMensaje");
            if (string.IsNullOrWhiteSpace(entidad.Titulo))
                throw new Exception("lbNotificacionSinTitulo");
            if (string.IsNullOrWhiteSpace(entidad.UrlDestino))
                throw new Exception("lbNotificacionSinDestino");
            this.IConexion!.Notificaciones!.Add(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public Notificaciones? Modificar(Notificaciones? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id == 0) throw new Exception("lbNoSeGuardo");
            var entidadExistente = this.IConexion!.Notificaciones!.Find(entidad.Id);
            if (entidadExistente == null)
                throw new Exception("lbEntidadNoEncontrada");
            entidadExistente.Leida = entidad.Leida;
            entidadExistente.Mensaje = entidad.Mensaje;
            entidadExistente.Titulo = entidad.Titulo;
            entidadExistente.UrlDestino = entidad.UrlDestino;
            this.IConexion!.Notificaciones!.Update(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public Notificaciones? Borrar(Notificaciones? entidad)
        {

            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id == 0) throw new Exception("lbNoSeGuardo");
            if (entidad.Leida == false)
                throw new Exception("lbNotificacionSinleer");
            this.IConexion!.Notificaciones!.Remove(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public List<Notificaciones> Listar() => this.IConexion!.Notificaciones!.Take(20).ToList();
    }
}

