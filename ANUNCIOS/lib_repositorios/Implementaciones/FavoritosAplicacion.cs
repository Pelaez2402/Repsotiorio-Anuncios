using lib_dominio.Entidades;
using lib_repositorios.Interfaces;


namespace lib_repositorios.Implementaciones
{
    public class FavoritosAplicacion : IFavoritosAplicacion
    {
        private IConexion? IConexion = null;

        public FavoritosAplicacion(IConexion iConexion) => this.IConexion = iConexion;

        public void Configurar(string StringConexion) => this.IConexion!.StringConexion = StringConexion;

        public Favoritos? Guardar(Favoritos? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id != 0) throw new Exception("lbYaSeGuardo");
            if (entidad.AnuncioId == 0) 
                throw new Exception("lbNoHayAnuncio");
            if (entidad.UsuarioId == 0)
                throw new Exception("lbUsuarioNovalido");
            if (entidad.Activo == false)
                throw new Exception("lbNoHayFavoritos");

            this.IConexion!.Favoritos!.Add(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public Favoritos? Modificar(Favoritos? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id == 0) throw new Exception("lbNoSeGuardo");
            var entidadExistente = this.IConexion!.Favoritos!.Find(entidad.Id);
            if (entidadExistente == null)
                throw new Exception("lbEntidadNoEncontrada");

            entidadExistente.Notas = entidad.Notas;
            entidadExistente.Activo = true;
            entidadExistente.FechaAgregado = DateTime.Now;
            this.IConexion!.Favoritos!.Update(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public Favoritos? Borrar(Favoritos? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id == 0) throw new Exception("lbNoSeGuardo");

            this.IConexion!.Favoritos!.Remove(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public List<Favoritos> Listar() => this.IConexion!.Favoritos!.Take(20).ToList();
    }
}

