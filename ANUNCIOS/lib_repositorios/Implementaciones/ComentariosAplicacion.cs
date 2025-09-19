using lib_dominio.Entidades;
using lib_repositorios.Interfaces;


namespace lib_repositorios.Implementaciones
{
    public class ComentariosAplicacion : IComentariosAplicacion
    {
        private IConexion? IConexion = null;

        public ComentariosAplicacion(IConexion iConexion) => this.IConexion = iConexion;

        public void Configurar(string StringConexion) => this.IConexion!.StringConexion = StringConexion;

        public Comentarios? Guardar(Comentarios? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id != 0) throw new Exception("lbYaSeGuardo");
            if (entidad.UsuarioId == 0) 
                throw new Exception("lbUsuarioNoValido");
            if (entidad.AnuncioId == 0)
                throw new Exception("lbAnuncioNoValido");
            if (string.IsNullOrWhiteSpace(entidad.Contenido))
                throw new Exception("lbComentarioSinContenido");
            if (entidad.Contenido.Equals("Palabra Soes"))
            {
                entidad.Activo = false;
                throw new Exception("lbComentarioInapropuiado");
            }
            if (entidad.ComentarioPadreId.HasValue)
            {
                var comentarioPadre = this.IConexion!.Comentarios!
                    .FirstOrDefault(c => c.Id == entidad.ComentarioPadreId.Value);

                if (comentarioPadre == null)
                    throw new Exception("lbComentarioPadreNoExiste");

                if (!comentarioPadre.Activo)
                    throw new Exception("lbComentarioPadreInactivo");
            }

            this.IConexion!.Comentarios!.Add(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public Comentarios? Modificar(Comentarios? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id == 0) throw new Exception("lbNoSeGuardo");
            var entidadExistente = this.IConexion!.Comentarios!.Find(entidad.Id);
           
            
            if (entidadExistente == null)
                throw new Exception("lbEntidadNoEncontrada");

            entidadExistente.Contenido = entidad.Contenido;
          
            this.IConexion!.Comentarios!.Update(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public Comentarios? Borrar(Comentarios? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id == 0) throw new Exception("lbNoSeGuardo");
            var tieneHijosActivos = this.IConexion!.Comentarios!
            .Any(c => c.ComentarioPadreId == entidad.Id && c.Activo);

            if (tieneHijosActivos)
                throw new Exception("lbComentarioTieneRespuestasActivas");
            this.IConexion!.Comentarios!.Remove(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public List<Comentarios> Listar() => this.IConexion!.Comentarios!.Take(20).ToList();
    }
}

