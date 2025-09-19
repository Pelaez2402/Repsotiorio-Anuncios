using lib_dominio.Entidades;
using lib_repositorios.Interfaces;


namespace lib_repositorios.Implementaciones
{
    public class PlanesDePublicacionAplicacion : IPlanesDePublicacionAplicacion
    {
        private IConexion? IConexion = null;

        public PlanesDePublicacionAplicacion(IConexion iConexion) => this.IConexion = iConexion;

        public void Configurar(string StringConexion) => this.IConexion!.StringConexion = StringConexion;

        public PlanesDePublicacion? Guardar(PlanesDePublicacion? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id != 0) throw new Exception("lbYaSeGuardo");
            if (entidad.Activo == false)
                throw new Exception("lbPlanNoValido");
            if (string.IsNullOrWhiteSpace(entidad.Nombre))
                throw new Exception("lbPlanSinNombre");
            if (string.IsNullOrWhiteSpace(entidad.Descripcion))
                throw new Exception("lbDescripcionNecesaria");
            if (entidad.Duracion <= 0)
                throw new Exception("lbDuracionNoValida");
            if (entidad.Precio <= 0)
                throw new Exception("lbPrecioNovalido");
            this.IConexion!.PlanesDePublicacion!.Add(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public PlanesDePublicacion? Modificar(PlanesDePublicacion? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id == 0) throw new Exception("lbNoSeGuardo");
            var entidadExistente = this.IConexion!.PlanesDePublicacion!.Find(entidad.Id);
            if (entidadExistente == null)
                throw new Exception("lbEntidadNoEncontrada");

            entidadExistente.Nombre = entidad.Nombre;
            entidadExistente.Precio = entidad.Precio;
            entidadExistente.FechaCreacion = DateTime.Now;
            entidadExistente.Descripcion = entidad.Descripcion;
            entidadExistente.Activo = true;

            this.IConexion!.PlanesDePublicacion!.Update(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public PlanesDePublicacion? Borrar(PlanesDePublicacion? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id == 0) throw new Exception("lbNoSeGuardo");
            if (!entidad.Activo)
                throw new Exception("lbAnuncioActivo");
            this.IConexion!.PlanesDePublicacion!.Remove(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public List<PlanesDePublicacion> Listar() => this.IConexion!.PlanesDePublicacion!.Take(20).ToList();
    }
}

