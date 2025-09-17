using lib_dominio.Entidades;
using lib_repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace lib_repositorios.Implementaciones
{
    public partial class Conexion : DbContext, IConexion
    {
        public string? StringConexion { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(this.StringConexion!, p => { });
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }
        public DbSet<Anuncios>? Anuncios { get; set; }
        public DbSet<AnunciosSubcategorias>? AnunciosSubcategorias { get; set; }
        public DbSet<Categorias>? Categorias { get; set; }
        public DbSet<Comentarios>? Comentarios { get; set; }
        public DbSet<Favoritos>? Favoritos { get; set; }
        public DbSet<ImagenesAnuncios>? ImagenesAnuncios { get; set; }
        public DbSet<Notificaciones>? Notificaciones { get; set; }
        public DbSet<Pagos>? Pagos { get; set; }
        public DbSet<PlanesDePublicacion>? PlanesDePublicacion { get; set; }
        public DbSet<ReportesDeAnuncios>? ReportesDeAnuncios { get; set; }
        public DbSet<Roles>? Roles { get; set; }
        public DbSet<Subcategorias>? Subcategorias { get; set; }
        public DbSet<Ubicaciones>? Ubicaciones { get; set; }
        public DbSet<Usuarios>? Usuarios { get; set; }
        public DbSet<UsuariosRoles>? UsuariosRoles { get; set; }


    }
}
