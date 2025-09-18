using lib_dominio.Entidades;
using lib_repositorios.Interfaces;



namespace lib_repositorios.Implementaciones
{
    public class UsuariosAplicacion : IUsuariosAplicacion
    {
        private IConexion? IConexion = null;

        public UsuariosAplicacion(IConexion iConexion) => this.IConexion = iConexion;

        public void Configurar(string StringConexion) => this.IConexion!.StringConexion = StringConexion;

        public Usuarios? Guardar(Usuarios? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id != 0) throw new Exception("lbYaSeGuardo");

            this.IConexion!.Usuarios!.Add(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public Usuarios? Modificar(Usuarios? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id == 0) throw new Exception("lbNoSeGuardo");

            this.IConexion!.Usuarios!.Update(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public Usuarios? Borrar(Usuarios? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id == 0) throw new Exception("lbNoSeGuardo");

            this.IConexion!.Usuarios!.Remove(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public List<Usuarios> Listar() => this.IConexion!.Usuarios!.Take(20).ToList();
    }
}

