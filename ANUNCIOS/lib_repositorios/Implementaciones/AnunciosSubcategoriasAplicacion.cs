using lib_dominio.Entidades;
using lib_repositorios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_repositorios.Implementaciones
{
    public interface IAnuncioSubcategoriaAplicacion
    {
        void Configurar(string StringConexion);
        AnuncioSubcategoria? Borrar(AnuncioSubcategoria? entidad);
        AnuncioSubcategoria? Guardar(AnuncioSubcategoria? entidad);
        List<AnuncioSubcategoria> Listar();
        AnuncioSubcategoria? Modificar(AnuncioSubcategoria? entidad);
    }

    public class AnunciosSubcategoriasAplicacion : IAnuncioSubcategoriaAplicacion
    {
        private IConexion? IConexion = null;

        public AnunciosSubcategoriasAplicacion(IConexion iConexion) => this.IConexion = iConexion;

        public void Configurar(string StringConexion) => this.IConexion!.StringConexion = StringConexion;

        public AnuncioSubcategoria? Guardar(AnuncioSubcategoria? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id != 0) throw new Exception("lbYaSeGuardo");

            this.IConexion!.AnunciosSubcategorias!.Add(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public AnuncioSubcategoria? Modificar(AnuncioSubcategoria? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id == 0) throw new Exception("lbNoSeGuardo");

            this.IConexion!.AnunciosSubcategorias!.Update(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public AnuncioSubcategoria? Borrar(AnuncioSubcategoria? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id == 0) throw new Exception("lbNoSeGuardo");

            this.IConexion!.AnunciosSubcategorias!.Remove(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public List<AnuncioSubcategoria> Listar() => this.IConexion!.AnunciosSubcategorias!.Take(20).ToList();
    }
}
}
