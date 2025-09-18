using lib_repositorios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_repositorios.Implementaciones
{
    public class ImagenesAnunciosAplicacion : IImagenAnuncioAplicacion
    {
        private IConexion? IConexion = null;

        public ImagenesAnunciosAplicacion(IConexion iConexion) => this.IConexion = iConexion;

        public void Configurar(string StringConexion) => this.IConexion!.StringConexion = StringConexion;

        public ImagenAnuncio? Guardar(ImagenAnuncio? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id != 0) throw new Exception("lbYaSeGuardo");

            this.IConexion!.ImagenesAnuncios!.Add(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public ImagenAnuncio? Modificar(ImagenAnuncio? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id == 0) throw new Exception("lbNoSeGuardo");

            this.IConexion!.ImagenesAnuncios!.Update(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public ImagenAnuncio? Borrar(ImagenAnuncio? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id == 0) throw new Exception("lbNoSeGuardo");

            this.IConexion!.ImagenesAnuncios!.Remove(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public List<ImagenAnuncio> Listar() => this.IConexion!.ImagenesAnuncios!.Take(20).ToList();
    }
}
}
