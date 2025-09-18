using lib_repositorios.Interfaces;
using lib_dominio.Entidades;
namespace lib_repositorios.Implementaciones
{
    public class RolesAplicacion : IRolesAplicacion
    {
        private IConexion? IConexion = null;

        public RolesAplicacion(IConexion iConexion) => this.IConexion = iConexion;

        public void Configurar(string StringConexion) => this.IConexion!.StringConexion = StringConexion;

        public Roles? Guardar(Roles? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id != 0) throw new Exception("lbYaSeGuardo");
            if (string.IsNullOrWhiteSpace(entidad.Nombre))
                throw new Exception("lbNombreDelRolRequerido");
            this.IConexion!.Roles!.Add(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public Roles? Modificar(Roles? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id == 0) throw new Exception("lbNoSeGuardo");
            var entidadExistente = this.IConexion!.Roles!.Find(entidad.Id);
            if (entidadExistente == null)
                throw new Exception("lbEntidadNoEncontrada");

            entidadExistente.Nombre = entidad.Nombre;
            
            this.IConexion!.Roles!.Update(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public Roles? Borrar(Roles? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id == 0) throw new Exception("lbNoSeGuardo");

            this.IConexion!.Roles!.Remove(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public List<Roles> Listar() => this.IConexion!.Roles!.Take(20).ToList();
    }
}

    
