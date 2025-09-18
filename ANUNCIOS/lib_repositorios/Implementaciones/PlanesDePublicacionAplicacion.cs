using lib_dominio.Entidades;
using lib_repositorios.Interfaces;


namespace lib_repositorios.Implementaciones
{
    public class PlanesDePublicacionAplicacion : IPlanesDePublicacionAplicacion
    {
        private IConexion? IConexion = null;

        public PlanesDePublicacionAplicacion(IConexion iConexion) => this.IConexion = iConexion;

        public void Configurar(string StringConexion) => this.IConexion!.StringConexion = StringConexion;

        public PlanesDePublicacion? Guardar(PlanesDePublicacion? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id != 0) throw new Exception("lbYaSeGuardo");

            this.IConexion!.PlanesDePublicacion!.Add(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public PlanesDePublicacion? Modificar(PlanesDePublicacion? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id == 0) throw new Exception("lbNoSeGuardo");

            this.IConexion!.PlanesDePublicacion!.Update(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public PlanesDePublicacion? Borrar(PlanesDePublicacion? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id == 0) throw new Exception("lbNoSeGuardo");

            this.IConexion!.PlanesDePublicacion!.Remove(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public List<PlanesDePublicacion> Listar() => this.IConexion!.PlanesDePublicacion!.Take(20).ToList();
    }
}

