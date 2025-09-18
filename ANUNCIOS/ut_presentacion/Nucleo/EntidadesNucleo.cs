
using lib_dominio.Entidades;

namespace ut_presentacion.Nucleo
{
    public class EntidadesNucleo
    {
        public static Anuncios? Anuncios()
        {
            var entidad = new Anuncios();
            entidad.Titulo = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss");
            entidad.Descripcion = "Descripción de prueba generada el " + DateTime.Now.ToString("yyyyMMddhhmmss");
            entidad.Precio = 99999.99M;
            entidad.FechaPublicacion = DateTime.Now;
            entidad.UsuarioId = 1; 
            entidad.UbicacionId = 1;
            entidad.Estado = true;
            entidad.PlanId = 1; 

            return entidad;
        }

        public static AnunciosSubcategorias? AnunciosSubcategorias()
        {
            var entidad = new AnunciosSubcategorias();
            entidad.AnuncioId = 1; 
            entidad.SubcategoriaId = 1; 
            entidad.AsignadoPor = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss");
            entidad.FechaAsignacion = DateTime.Now;

            return entidad;
        }

        public static Categorias? Categorias()
        {
            var entidad = new Categorias();

            entidad.Nombre = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss");
            entidad.Descripcion = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss");
            entidad.FechaCreacion = DateTime.Now;
            entidad.Activo = true;

            return entidad;
        }

        public static Comentarios? Comentarios()
        {
            var entidad = new Comentarios();
            entidad.Contenido = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss");
            entidad.FechaCreacion = DateTime.Now;
            entidad.UsuarioId = 1; 
            entidad.AnuncioId = 1; 
            entidad.ComentarioPadreId = null; 
            entidad.Activo = true;

            return entidad;
        }

        public static Favoritos? Favoritos()
        {
            var entidad = new Favoritos();

            entidad.UsuarioId = 1; 
            entidad.AnuncioId = 1; 
            entidad.FechaAgregado = DateTime.Now;
            entidad.Notas = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss");
            entidad.Activo = true;

            return entidad;
        }

        public static ImagenesAnuncios? ImagenesAnuncios()
        {
            var entidad = new ImagenesAnuncios();
            entidad.Url = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss");
            entidad.Titulo = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss");
            entidad.FechaSubida = DateTime.Now;
            entidad.AnuncioId = 1; 
            entidad.UsuarioId = 1; 

            return entidad;
        }

        public static Notificaciones? Notificaciones()
        {
            var entidad = new Notificaciones();
            entidad.UsuarioId = 1; 
            entidad.Titulo = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss");
            entidad.Mensaje = "Mensaje de prueba generado el " + DateTime.Now.ToString("yyyyMMddhhmmss");
            entidad.FechaCreacion = DateTime.Now;
            entidad.Leida = false;
            entidad.UrlDestino = "https://pruebas/" + DateTime.Now.ToString("yyyyMMddhhmmss");
            return entidad;
        }

        public static Pagos? Pagos()
        {
            var entidad = new Pagos();
            entidad.Monto = 99999.99M;
            entidad.UsuarioId = 1; 
            entidad.PlanId = 1;
            entidad.AnuncioId = 1; 
            entidad.FechaPago = DateTime.Now;
            entidad.MetodoPago = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss");
            entidad.Estado = "PENDIENTE";

            return entidad;
        }

        public static PlanesDePublicacion? PlanesDePublicacion()
        {
            var entidad = new PlanesDePublicacion();

            entidad.Nombre = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss");
            entidad.Precio = 99999m;
            entidad.Duracion = 30;
            entidad.Descripcion = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss");
            entidad.FechaCreacion = DateTime.Now;
            entidad.Activo = true;

            return entidad;
        }

        public static ReportesDeAnuncios? ReportesDeAnuncios()
        {
            var entidad = new ReportesDeAnuncios();
            entidad.Motivo = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss");
            entidad.FechaReporte = DateTime.Now;
            entidad.UsuarioId = 1; 
            entidad.AnuncioId = 1; 
            entidad.Estado = "PENDIENTE";

            return entidad;
        }

        public static Roles? Roles()
        {
            var entidad = new Roles();
            entidad.Nombre = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss");
            entidad.Descripcion = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss");
            entidad.FechaCreacion = DateTime.Now;

            return entidad;
        }

        public static Subcategorias? Subcategorias()
        {
            var entidad = new Subcategorias();
            entidad.Nombre = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss");
            entidad.Descripcion = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss");
            entidad.CategoriaId = 1; 
            entidad.FechaCreacion = DateTime.Now;
            entidad.Activo = true;
            return entidad;
        }

        public static Ubicaciones? Ubicaciones()
        {
            var entidad = new Ubicaciones();

            entidad.Nombre = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss");
            entidad.Direccion = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss");
            entidad.Ciudad = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss");
            entidad.Pais = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss");


            return entidad;
        }

        public static Usuarios? Usuarios()
        {
            var entidad = new Usuarios();
            entidad.Nombre = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss");
            entidad.Correo = "pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss") + "@correo.com";
            entidad.Contraseña = "Pruebas123*";
            entidad.Telefono = "0000000000";
            entidad.FechaRegistro = DateTime.Now;

            return entidad;
        }

        public static UsuariosRoles? UsuariosRoles()
        {
            var entidad = new UsuariosRoles();
            entidad.UsuarioId = 1; 
            entidad.RolId = 1; 
            entidad.FechaAsignacion = DateTime.Now;
            entidad.AsignadoPor = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss");
            entidad.Activo = true;

            return entidad;
        }

    }
}
