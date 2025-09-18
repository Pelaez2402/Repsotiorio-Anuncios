using lib_dominio.Entidades;
using lib_repositorios.Interfaces;


namespace lib_repositorios.Implementaciones
{
    public class CategoriasAplicacion : ICategoriasAplicacion
    {
        private IConexion? IConexion = null;

        public CategoriasAplicacion(IConexion iConexion) => this.IConexion = iConexion;

        public void Configurar(string StringConexion) => this.IConexion!.StringConexion = StringConexion;

        public Categorias? Guardar(Categorias? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id != 0) throw new Exception("lbYaSeGuardo");

            this.IConexion!.Categorias!.Add(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public Categorias? Modificar(Categorias? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id == 0) throw new Exception("lbNoSeGuardo");

            this.IConexion!.Categorias!.Update(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public Categorias? Borrar(Categorias? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id == 0) throw new Exception("lbNoSeGuardo");

            this.IConexion!.Categorias!.Remove(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public List<Categorias> Listar() => this.IConexion!.Categorias!.Take(20).ToList();
    }
}

