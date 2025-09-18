using lib_repositorios.Interfaces;

using lib_dominio.Entidades;

namespace lib_repositorios.Implementaciones
{
    public class UsuariosRolesAplicacion : IUsuariosRolesAplicacion
    {
        private IConexion? IConexion = null;

        public UsuariosRolesAplicacion(IConexion iConexion) => this.IConexion = iConexion;

        public void Configurar(string StringConexion) => this.IConexion!.StringConexion = StringConexion;

        public UsuariosRoles? Guardar(UsuariosRoles? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id != 0) throw new Exception("lbYaSeGuardo");

            this.IConexion!.UsuariosRoles!.Add(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public UsuariosRoles? Modificar(UsuariosRoles? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id == 0) throw new Exception("lbNoSeGuardo");

            this.IConexion!.UsuariosRoles!.Update(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public UsuariosRoles? Borrar(UsuariosRoles? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id == 0) throw new Exception("lbNoSeGuardo");

            this.IConexion!.UsuariosRoles!.Remove(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public List<UsuariosRoles> Listar() => this.IConexion!.UsuariosRoles!.Take(20).ToList();
    }
}

