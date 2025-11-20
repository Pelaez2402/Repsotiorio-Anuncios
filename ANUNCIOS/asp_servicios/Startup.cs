using lib_repositorios.Implementaciones;
using lib_repositorios.Interfaces;
using asp_servicios.Controllers;
using Microsoft.AspNetCore.Server.Kestrel.Core;

namespace asp_servicios
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
            services.Configure<KestrelServerOptions>(x => {
                x.AllowSynchronousIO = true;
            });
            services.Configure<IISServerOptions>(x => { x.AllowSynchronousIO = true; });
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            //services.AddSwaggerGen();

            // Repositorios
            services.AddScoped<IConexion, Conexion>();
            services.AddScoped<IAnunciosAplicacion, AnunciosAplicacion>();
            services.AddScoped<IAnunciosSubcategoriasAplicacion, AnunciosSubcategoriasAplicacion>();
            services.AddScoped<ICategoriasAplicacion, CategoriasAplicacion>();
            services.AddScoped<IComentariosAplicacion, ComentariosAplicacion>();
            services.AddScoped<IFavoritosAplicacion, FavoritosAplicacion>();
            services.AddScoped<IImagenesAnunciosAplicacion, ImagenesAnunciosAplicacion>();
            services.AddScoped<INotificacionesAplicacion, NotificacionesAplicacion>();
            services.AddScoped<IPagosAplicacion, PagosAplicacion>();
            services.AddScoped<IPlanesDePublicacionAplicacion, PlanesDePublicacionAplicacion>();
            services.AddScoped<IReportesDeAnunciosAplicacion, ReportesDeAnunciosAplicacion>();
            services.AddScoped<IRolesAplicacion, RolesAplicacion>();
            services.AddScoped<ISubcategoriasAplicacion, SubcategoriasAplicacion>();
            services.AddScoped<IUbicacionesAplicacion, UbicacionesAplicacion>();
            services.AddScoped<IUsuariosAplicacion, UsuariosAplicacion>();
            services.AddScoped<IUsuariosRolesAplicacion, UsuariosRolesAplicacion>();
            services.AddScoped<TokenAplicacion, TokenAplicacion>();
            // Controladores
            services.AddScoped<TokenController, TokenController>();
            services.AddCors(o => o.AddDefaultPolicy(b => b.AllowAnyOrigin()));
        }

        public void Configure(WebApplication app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                //app.UseSwagger();
                //app.UseSwaggerUI();
            }
            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();
            app.Run();
            app.UseRouting();
            app.UseCors();
        }
    }
}