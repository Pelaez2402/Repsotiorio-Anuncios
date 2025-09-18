using lib_repositorios.Interfaces;
using lib_dominio.Entidades;
namespace lib_repositorios.Implementaciones
{
    public class RolesAplicacion : IRolAplicacion
    {
        private IConexion? IConexion = null;

        public RolesAplicacion(IConexion iConexion) => this.IConexion = iConexion;

        public void Configurar(string StringConexion) => this.IConexion!.StringConexion = StringConexion;

        public Rol? Guardar(Rol? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id != 0) throw new Exception("lbYaSeGuardo");

            this.IConexion!.Roles!.Add(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public Rol? Modificar(Rol? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id == 0) throw new Exception("lbNoSeGuardo");

            this.IConexion!.Roles!.Update(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public Rol? Borrar(Rol? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id == 0) throw new Exception("lbNoSeGuardo");

            this.IConexion!.Roles!.Remove(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public List<Rol> Listar() => this.IConexion!.Roles!.Take(20).ToList();
    }
}
} 
    
