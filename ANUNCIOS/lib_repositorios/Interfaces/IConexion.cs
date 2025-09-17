using lib_dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace lib_repositorios.Interfaces
{
    public interface IConexion
    {
        string? StringConexion { get; set; }
        DbSet<Anuncios>? Anuncios { get; set; }
        DbSet<AnunciosSubcategorias>? AnunciosSubcategorias { get; set; }
        DbSet<Categorias>? Categorias { get; set; }
        DbSet<Comentarios>? Comentarios { get; set; }
        DbSet<Favoritos>? Favoritos { get; set; }
        DbSet<ImagenesAnuncios>? ImagenesAnuncios { get; set; }
        DbSet<Notificaciones>? Notificaciones { get; set; }
        DbSet<Pagos>? Pagos { get; set; }
        DbSet<PlanesDePublicacion>? PlanesDePublicacion { get; set; }
        DbSet<ReportesDeAnuncios>? ReportesDeAnuncios { get; set; }
        DbSet<Roles>? Roles { get; set; }
        DbSet<Subcategorias>? Subcategorias { get; set; }
        DbSet<Ubicaciones>? Ubicaciones { get; set; }
        DbSet<Usuarios>? Usuarios { get; set; }
        DbSet<UsuariosRoles>? UsuariosRoles { get; set; }

        EntityEntry<T> Entry<T>(T entity) where T : class;
        int SaveChanges();
    }
}
