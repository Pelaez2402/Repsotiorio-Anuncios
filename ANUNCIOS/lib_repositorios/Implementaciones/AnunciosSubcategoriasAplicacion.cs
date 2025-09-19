using lib_dominio.Entidades;
using lib_repositorios.Interfaces;


namespace lib_repositorios.Implementaciones
{
    public class AnunciosSubcategoriasAplicacion : IAnunciosSubcategoriasAplicacion
    {
        private IConexion? IConexion = null;

        public AnunciosSubcategoriasAplicacion(IConexion iConexion) => this.IConexion = iConexion;

        public void Configurar(string StringConexion) => this.IConexion!.StringConexion = StringConexion;

        public AnunciosSubcategorias? Guardar(AnunciosSubcategorias? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id != 0) throw new Exception("lbYaSeGuardo");
            if (entidad.AnuncioId == 0)
                throw new Exception("lbAnuncioNoValido");
            if (entidad.SubcategoriaId == 0)
                throw new Exception("lbSubcategoriaInvalida");

            this.IConexion!.AnunciosSubcategorias!.Add(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public AnunciosSubcategorias? Modificar(AnunciosSubcategorias? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");

            if (entidad.Id == 0) throw new Exception("lbNoSeGuardo");

            var entidadExistente = this.IConexion!.AnunciosSubcategorias!.Find(entidad.Id);
            if (entidadExistente == null)
                throw new Exception("lbEntidadNoEncontrada");

            entidadExistente.AsignadoPor = entidad.AsignadoPor;
            entidadExistente.FechaAsignacion = DateTime.Now;
          

            this.IConexion!.AnunciosSubcategorias!.Update(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public AnunciosSubcategorias? Borrar(AnunciosSubcategorias? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id == 0) throw new Exception("lbNoSeGuardo");

            this.IConexion!.AnunciosSubcategorias!.Remove(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public List<AnunciosSubcategorias> Listar() => this.IConexion!.AnunciosSubcategorias!.Take(20).ToList();
    }
}

