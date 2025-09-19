using lib_dominio.Entidades;
using lib_repositorios.Interfaces;



namespace lib_repositorios.Implementaciones
{
    public class UsuariosAplicacion : IUsuariosAplicacion
    {
        private IConexion? IConexion = null;

        public UsuariosAplicacion(IConexion iConexion) => this.IConexion = iConexion;

        public void Configurar(string StringConexion) => this.IConexion!.StringConexion = StringConexion;

        private bool CorreoYaExiste(string correo, int usuarioIdActual)
        {
            return this.IConexion!.Usuarios!
                .Any(u => u.Correo == correo && u.Id != usuarioIdActual);
        }
        
        public Usuarios? Guardar(Usuarios? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id != 0) throw new Exception("lbYaSeGuardo");
            if (CorreoYaExiste(entidad.Correo, entidad.Id))
                throw new Exception("lbElCorreoElectrónicoYaEstáRegistrado");
            this.IConexion!.Usuarios!.Add(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public Usuarios? Modificar(Usuarios? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id == 0) throw new Exception("lbNoSeGuardo");
          
            
            var entidadExistente = this.IConexion!.Usuarios!.Find(entidad.Id);
            if (entidadExistente == null)
                throw new Exception("lbEntidadNoEncontrada");

            entidadExistente.Correo = entidad.Correo;
            entidadExistente.Contraseña = entidad.Contraseña;
            entidadExistente.Telefono = entidad.Telefono;
            entidadExistente.FechaRegistro = DateTime.Now; 
            if (CorreoYaExiste(entidad.Correo, entidad.Id))
                throw new Exception("lbElCorreoElectrónicoYaEstáRegistrado");
            this.IConexion!.Usuarios!.Update(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public Usuarios? Borrar(Usuarios? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id == 0) throw new Exception("lbNoSeGuardo");
            bool tieneAnunciosActivos = this.IConexion!.Anuncios!
            .Any(a => a.UsuarioId == entidad.Id && a.Estado == true);

            if (tieneAnunciosActivos)
                throw new Exception("lbNoSePuedeEliminarElUsuarioPorqueTieneAnunciosActivos");

            this.IConexion!.Usuarios!.Remove(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public List<Usuarios> Listar() => this.IConexion!.Usuarios!.Take(20).ToList();
    }
}

