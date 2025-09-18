using lib_repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_repositorios.Implementaciones
{
    public class UsuariosRolesAplicacion : IUsuarioRolAplicacion
    {
        private IConexion? IConexion = null;

        public UsuariosRolesAplicacion(IConexion iConexion) => this.IConexion = iConexion;

        public void Configurar(string StringConexion) => this.IConexion!.StringConexion = StringConexion;

        public UsuarioRol? Guardar(UsuarioRol? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id != 0) throw new Exception("lbYaSeGuardo");

            this.IConexion!.UsuariosRoles!.Add(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public UsuarioRol? Modificar(UsuarioRol? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id == 0) throw new Exception("lbNoSeGuardo");

            this.IConexion!.UsuariosRoles!.Update(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public UsuarioRol? Borrar(UsuarioRol? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id == 0) throw new Exception("lbNoSeGuardo");

            this.IConexion!.UsuariosRoles!.Remove(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public List<UsuarioRol> Listar() => this.IConexion!.UsuariosRoles!.Take(20).ToList();
    }
}
}
