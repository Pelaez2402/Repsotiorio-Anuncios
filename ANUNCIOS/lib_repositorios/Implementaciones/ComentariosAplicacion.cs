using lib_dominio.Entidades;
using lib_repositorios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_repositorios.Implementaciones
{
    public class ComentariosAplicacion : IComentarioAplicacion
    {
        private IConexion? IConexion = null;

        public ComentariosAplicacion(IConexion iConexion) => this.IConexion = iConexion;

        public void Configurar(string StringConexion) => this.IConexion!.StringConexion = StringConexion;

        public Comentario? Guardar(Comentario? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id != 0) throw new Exception("lbYaSeGuardo");

            this.IConexion!.Comentarios!.Add(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public Comentario? Modificar(Comentario? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id == 0) throw new Exception("lbNoSeGuardo");

            this.IConexion!.Comentarios!.Update(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public Comentario? Borrar(Comentario? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id == 0) throw new Exception("lbNoSeGuardo");

            this.IConexion!.Comentarios!.Remove(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public List<Comentario> Listar() => this.IConexion!.Comentarios!.Take(20).ToList();
    }
}
}
