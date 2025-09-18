using lib_repositorios.Interfaces;

using lib_dominio.Entidades;

namespace lib_repositorios.Implementaciones
{
    public class ImagenesAnunciosAplicacion : IImagenesAnunciosAplicacion
    {
        private IConexion? IConexion = null;

        public ImagenesAnunciosAplicacion(IConexion iConexion) => this.IConexion = iConexion;

        public void Configurar(string StringConexion) => this.IConexion!.StringConexion = StringConexion;

        public ImagenesAnuncios? Guardar(ImagenesAnuncios? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id != 0) throw new Exception("lbYaSeGuardo");

            this.IConexion!.ImagenesAnuncios!.Add(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public ImagenesAnuncios? Modificar(ImagenesAnuncios? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id == 0) throw new Exception("lbNoSeGuardo");

            this.IConexion!.ImagenesAnuncios!.Update(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public ImagenesAnuncios? Borrar(ImagenesAnuncios? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id == 0) throw new Exception("lbNoSeGuardo");

            this.IConexion!.ImagenesAnuncios!.Remove(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public List<ImagenesAnuncios> Listar() => this.IConexion!.ImagenesAnuncios!.Take(20).ToList();
    }
}

