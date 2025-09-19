using lib_dominio.Entidades;
using lib_repositorios.Interfaces;



namespace lib_repositorios.Implementaciones
{
    public class SubcategoriasAplicacion : ISubcategoriasAplicacion
    {
        private IConexion? IConexion = null;

        public SubcategoriasAplicacion(IConexion iConexion) => this.IConexion = iConexion;

        public void Configurar(string StringConexion) => this.IConexion!.StringConexion = StringConexion;

        public Subcategorias? Guardar(Subcategorias? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id != 0) throw new Exception("lbYaSeGuardo");
            if (entidad.CategoriaId == 0)
                throw new("lbCategoriaNovalida");
            if (string.IsNullOrWhiteSpace(entidad.Nombre))
                throw new Exception("lbSubcatecoriaSinNombre");
            if (string.IsNullOrWhiteSpace(entidad.Descripcion))
                throw new Exception("lbSubcategoriaSinDescripcion");

            this.IConexion!.Subcategorias!.Add(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public Subcategorias? Modificar(Subcategorias? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id == 0) throw new Exception("lbNoSeGuardo");
            var entidadExistente = this.IConexion!.Subcategorias!.Find(entidad.Id);
            if (entidadExistente == null)
                throw new Exception("lbEntidadNoEncontrada");

            entidadExistente.Nombre = entidad.Nombre;
            entidadExistente.Descripcion = entidad.Descripcion;
            entidadExistente.Activo = true;
            entidad.FechaCreacion = DateTime.Now;
            this.IConexion!.Subcategorias!.Update(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public Subcategorias? Borrar(Subcategorias? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id == 0) throw new Exception("lbNoSeGuardo");
            if (!entidad.Activo)
                throw new Exception("lbSubcategoriaActiva");
            this.IConexion!.Subcategorias!.Remove(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public List<Subcategorias> Listar() => this.IConexion!.Subcategorias!.Take(20).ToList();
    }
}

