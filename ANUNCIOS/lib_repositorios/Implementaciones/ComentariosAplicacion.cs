using lib_dominio.Entidades;
using lib_repositorios.Interfaces;


namespace lib_repositorios.Implementaciones
{
    public class ComentariosAplicacion : IComentariosAplicacion
    {
        private IConexion? IConexion = null;

        public ComentariosAplicacion(IConexion iConexion) => this.IConexion = iConexion;

        public void Configurar(string StringConexion) => this.IConexion!.StringConexion = StringConexion;

        public Comentarios? Guardar(Comentarios? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id != 0) throw new Exception("lbYaSeGuardo");

            this.IConexion!.Comentarios!.Add(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public Comentarios? Modificar(Comentarios? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id == 0) throw new Exception("lbNoSeGuardo");

            this.IConexion!.Comentarios!.Update(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public Comentarios? Borrar(Comentarios? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id == 0) throw new Exception("lbNoSeGuardo");

            this.IConexion!.Comentarios!.Remove(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public List<Comentarios> Listar() => this.IConexion!.Comentarios!.Take(20).ToList();
    }
}

