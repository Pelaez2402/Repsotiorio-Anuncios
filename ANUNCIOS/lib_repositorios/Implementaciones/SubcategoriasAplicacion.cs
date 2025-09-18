using lib_dominio.Entidades;
using lib_repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_repositorios.Implementaciones
{
    public class SubcategoriasAplicacion : ISubcategoriaAplicacion
    {
        private IConexion? IConexion = null;

        public SubcategoriasAplicacion(IConexion iConexion) => this.IConexion = iConexion;

        public void Configurar(string StringConexion) => this.IConexion!.StringConexion = StringConexion;

        public Subcategoria? Guardar(Subcategoria? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id != 0) throw new Exception("lbYaSeGuardo");

            this.IConexion!.Subcategorias!.Add(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public Subcategoria? Modificar(Subcategoria? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id == 0) throw new Exception("lbNoSeGuardo");

            this.IConexion!.Subcategorias!.Update(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public Subcategoria? Borrar(Subcategoria? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id == 0) throw new Exception("lbNoSeGuardo");

            this.IConexion!.Subcategorias!.Remove(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public List<Subcategoria> Listar() => this.IConexion!.Subcategorias!.Take(20).ToList();
    }
}
}
