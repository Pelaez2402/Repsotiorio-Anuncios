
using lib_dominio.Entidades;

namespace ut_presentacion.Nucleo
{
    public class EntidadesNucleo
    {
        public static Anuncios? Anuncios()
        {
            var entidad = new Anuncios();

            return entidad;
        }

        public static AnunciosSubcategorias? AnunciosSubcategorias()
        {
            var entidad = new AnunciosSubcategorias();
            return entidad;
        }

        public static Categorias? Categorias()
        {
            var entidad = new Categorias();
            return entidad;
        }

        public static Comentarios? Comentarios()
        {
            var entidad = new Comentarios();
            return entidad;
        }

        public static Favoritos? Favoritos()
        {
            var entidad = new Favoritos();
            return entidad;
        }

        public static ImagenesAnuncios? ImagenesAnuncios()
        {
            var entidad = new ImagenesAnuncios();
            return entidad;
        }

        public static Notificaciones? Notificaciones()
        {
            var entidad = new Notificaciones();
            return entidad;
        }

        public static Pagos? Pagos()
        {
            var entidad = new Pagos();
            return entidad;
        }

        public static PlanesDePublicacion? PlanesDePublicacion()
        {
            var entidad = new PlanesDePublicacion();
            return entidad;
        }

        public static ReportesDeAnuncios? ReportesDeAnuncios()
        {
            var entidad = new ReportesDeAnuncios();
            return entidad;
        }

        public static Roles? Roles()
        {
            var entidad = new Roles();
            return entidad;
        }

        public static Subcategorias? Subcategorias()
        {
            var entidad = new Subcategorias();
            return entidad;
        }

        public static Ubicaciones? Ubicaciones()
        {
            var entidad = new Ubicaciones();
            return entidad;
        }

        public static Usuarios? Usuarios()
        {
            var entidad = new Usuarios();
            return entidad;
        }

        public static UsuariosRoles? UsuariosRoles()
        {
            var entidad = new UsuariosRoles();
            return entidad;
        }

    }
}
