using lib_dominio.Entidades;
using lib_repositorios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_repositorios.Implementaciones
{
    public class FavoritosAplicacion : IFavoritoAplicacion
    {
        private IConexion? IConexion = null;

        public FavoritosAplicacion(IConexion iConexion) => this.IConexion = iConexion;

        public void Configurar(string StringConexion) => this.IConexion!.StringConexion = StringConexion;

        public Favorito? Guardar(Favorito? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id != 0) throw new Exception("lbYaSeGuardo");

            this.IConexion!.Favoritos!.Add(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public Favorito? Modificar(Favorito? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id == 0) throw new Exception("lbNoSeGuardo");

            this.IConexion!.Favoritos!.Update(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public Favorito? Borrar(Favorito? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id == 0) throw new Exception("lbNoSeGuardo");

            this.IConexion!.Favoritos!.Remove(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public List<Favorito> Listar() => this.IConexion!.Favoritos!.Take(20).ToList();
    }
}
}
