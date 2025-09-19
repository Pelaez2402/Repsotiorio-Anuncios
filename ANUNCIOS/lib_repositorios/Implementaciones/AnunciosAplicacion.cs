using lib_dominio.Entidades;
using lib_repositorios.Interfaces;


namespace lib_repositorios.Implementaciones
{
    public class AnunciosAplicacion : IAnunciosAplicacion
    {
        private IConexion? IConexion = null;

        public AnunciosAplicacion(IConexion iConexion) => this.IConexion = iConexion;

        public void Configurar(string StringConexion) => this.IConexion!.StringConexion = StringConexion;

        public Anuncios? Guardar(Anuncios? entidad)
        {
            if (entidad == null)
                throw new Exception("lbFaltaInformacion");

            if (entidad.Id != 0)
                throw new Exception("lbYaSeGuardo");


            if (string.IsNullOrWhiteSpace(entidad.Titulo))
                throw new Exception("lbTituloRequerido");

            if (entidad.UsuarioId == 0) 
                throw new Exception("lbNoRegistraUsuario");


            if (entidad.UbicacionId == 0)
                throw new Exception("lbNoRegistraUbicacion");

            if (entidad.FechaPublicacion == default(DateTime))
                entidad.FechaPublicacion = DateTime.Now;

            this.IConexion!.Anuncios!.Add(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public Anuncios? Modificar(Anuncios? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");

            if (entidad.Id == 0) throw new Exception("lbNoSeGuardo");

            var entidadExistente = this.IConexion!.Anuncios!.Find(entidad.Id);
            if (entidadExistente == null)
                throw new Exception("lbEntidadNoEncontrada");

            entidadExistente.Titulo = entidad.Titulo;
            entidadExistente.Descripcion = entidad.Descripcion;
            entidadExistente.Precio = entidad.Precio;
            entidadExistente.Estado = entidad.Estado;
            


            this.IConexion!.Anuncios!.Update(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public Anuncios? Borrar(Anuncios? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id == 0) throw new Exception("lbNoSeGuardo");
            var entidadExistente = this.IConexion!.Anuncios!.Find(entidad.Id);
            if (entidadExistente == null)
                throw new Exception("lbEntidadNoEncontrada");

            this.IConexion!.Anuncios!.Remove(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public List<Anuncios> Listar() => this.IConexion!.Anuncios!.Take(20).ToList();
    }
}

