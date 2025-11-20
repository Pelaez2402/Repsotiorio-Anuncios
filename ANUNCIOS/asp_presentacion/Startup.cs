using lib_presentaciones.Interfaces;
using lib_presentaciones.Implementaciones;
namespace asp_presentacion
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public static IConfiguration? Configuration { set; get; }

        public void ConfigureServices(WebApplicationBuilder builder, IServiceCollection services)
        {
            // Presentaciones
            services.AddScoped<IAnunciosPresentacion, AnunciosPresentacion>();
            services.AddScoped<IAnunciosSubcategoriasPresentacion, AnunciosSubcategoriasPresentacion>();
            services.AddScoped<ICategoriasPresentacion, CategoriasPresentacion>();
            services.AddScoped<IComentariosPresentacion, ComentariosPresentacion>();
            services.AddScoped<IFavoritosPresentacion, FavoritosPresentacion>();
            services.AddScoped<IImagenesAnunciosPresentacion, ImagenesAnunciosPresentacion>();
            services.AddScoped<INotificacionesPresentacion, NotificacionesPresentacion>();
            services.AddScoped<IPagosPresentacion, PagosPresentacion>();
            services.AddScoped<IPlanesDePublicacionPresentacion, PlanesDePublicacionPresentacion>();
            services.AddScoped<IReportesDeAnunciosPresentacion, ReportesDeAnunciosPresentacion>();
            services.AddScoped<IRolesPresentacion, RolesPresentacion>();
            services.AddScoped<ISubcategoriasPresentacion, SubcategoriasPresentacion>();
            services.AddScoped<IUbicacionesPresentacion, UbicacionesPresentacion>();
            services.AddScoped<IUsuariosPresentacion, UsuariosPresentacion>();
            services.AddScoped<IUsuariosRolesPresentacion, UsuariosRolesPresentacion>();
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddRazorPages();
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(30);
            });
        }

        public void Configure(WebApplication app, IWebHostEnvironment env)
        {
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
            }
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();
            app.MapRazorPages();
            app.UseSession();
            app.Run();
        }
    
    }
}
