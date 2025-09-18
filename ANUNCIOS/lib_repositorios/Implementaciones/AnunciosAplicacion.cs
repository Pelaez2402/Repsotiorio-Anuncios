using lib_dominio.Entidades;
using lib_repositorios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_repositorios.Implementaciones
{
    public class AnunciosAplicacion : IAnunciosAplicacion
    {
        private IConexion? IConexion = null;

        public AnunciosAplicacion(IConexion iConexion) => this.IConexion = iConexion;

        public void Configurar(string StringConexion) => this.IConexion!.StringConexion = StringConexion;

        public Anuncios? Guardar(Anuncios? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id != 0) throw new Exception("lbYaSeGuardo");

            this.IConexion!.Anuncios!.Add(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public Anuncios? Modificar(Anuncios? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id == 0) throw new Exception("lbNoSeGuardo");

            this.IConexion!.Anuncios!.Update(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public Anuncios? Borrar(Anuncios? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id == 0) throw new Exception("lbNoSeGuardo");

            this.IConexion!.Anuncios!.Remove(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public List<Anuncios> Listar() => this.IConexion!.Anuncios!.Take(20).ToList();
    }
}

