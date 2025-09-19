using lib_dominio.Entidades;
using lib_repositorios.Interfaces;

namespace lib_repositorios.Implementaciones
{
    public class UbicacionesAplicacion : IUbicacionesAplicacion
    {
        private IConexion? IConexion = null;

        public UbicacionesAplicacion(IConexion iConexion) => this.IConexion = iConexion;

        public void Configurar(string StringConexion) => this.IConexion!.StringConexion = StringConexion;
        private bool TieneAnunciosAsociados(int ubicacionId)
        {
            return this.IConexion!.Anuncios!
                .Any(a => a.UbicacionId == ubicacionId);
        }
        public Ubicaciones? Guardar(Ubicaciones? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id != 0) throw new Exception("lbYaSeGuardo");
            if (string.IsNullOrWhiteSpace(entidad.Nombre))
                throw new Exception("lbUbicacionSinNombre");
            //if (entidad.Pais != "Colombia")
               // throw new Exception("lbPaisSinCovertura");
            if (string.IsNullOrWhiteSpace(entidad.Ciudad))
                throw new Exception("lbEspecifiqueCiudad");
            if (string.IsNullOrWhiteSpace(entidad.Direccion))
                throw new Exception("lbEspecifiqueDireccion");
            this.IConexion!.Ubicaciones!.Add(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public Ubicaciones? Modificar(Ubicaciones? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id == 0) throw new Exception("lbNoSeGuardo");
           
            var entidadExistente = this.IConexion!.Ubicaciones!.Find(entidad.Id);
            if (entidadExistente == null)
                throw new Exception("lbEntidadNoEncontrada");

            entidadExistente.Ciudad = entidad.Ciudad;
            entidadExistente.Direccion = entidad.Direccion;
            entidadExistente.Nombre = entidad.Nombre;
            entidadExistente.Pais = entidad.Pais;
            //if (entidad.Pais != "Colombia")
               // throw new Exception("lbPaisSinCovertura");
            this.IConexion!.Ubicaciones!.Update(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public Ubicaciones? Borrar(Ubicaciones? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id == 0) throw new Exception("lbNoSeGuardo");
            if (TieneAnunciosAsociados(entidad.Id))
                throw new Exception("lbUbicacionConAnuncios");
            this.IConexion!.Ubicaciones!.Remove(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public List<Ubicaciones> Listar() => this.IConexion!.Ubicaciones!.Take(20).ToList();
    }
}

