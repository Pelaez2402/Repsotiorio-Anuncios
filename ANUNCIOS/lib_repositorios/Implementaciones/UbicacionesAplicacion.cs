using lib_dominio.Entidades;
using lib_repositorios.Interfaces;

namespace lib_repositorios.Implementaciones
{
    public class UbicacionesAplicacion : IUbicacionesAplicacion
    {
        private IConexion? IConexion = null;

        public UbicacionesAplicacion(IConexion iConexion) => this.IConexion = iConexion;

        public void Configurar(string StringConexion) => this.IConexion!.StringConexion = StringConexion;

        public Ubicaciones? Guardar(Ubicaciones? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id != 0) throw new Exception("lbYaSeGuardo");

            this.IConexion!.Ubicaciones!.Add(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public Ubicaciones? Modificar(Ubicaciones? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id == 0) throw new Exception("lbNoSeGuardo");

            this.IConexion!.Ubicaciones!.Update(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public Ubicaciones? Borrar(Ubicaciones? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id == 0) throw new Exception("lbNoSeGuardo");

            this.IConexion!.Ubicaciones!.Remove(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public List<Ubicaciones> Listar() => this.IConexion!.Ubicaciones!.Take(20).ToList();
    }
}

