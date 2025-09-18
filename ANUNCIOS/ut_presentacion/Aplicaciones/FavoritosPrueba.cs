
using lib_dominio.Entidades;
using lib_repositorios.Implementaciones;
using lib_repositorios.Interfaces;
using ut_presentacion.Nucleo;

namespace ut_presentacion.Aplicaciones
{
    [TestClass]
    
    public class FavoritosPrueba
    {
        private readonly IFavoritosAplicacion? iAplicacion;
        private readonly IConexion? iConexion;
        private List<Favoritos>? lista;
        private Favoritos? entidad;

        public FavoritosPrueba()
        {
            iConexion = new Conexion();
            iConexion.StringConexion = Configuracion.ObtenerValor("StringConexion");
            iAplicacion = new FavoritosAplicacion(iConexion);
        }

        [TestMethod]
        public void Ejecutar()
        {
            Assert.AreEqual(true, Guardar());
            Assert.AreEqual(true, Modificar());
            Assert.AreEqual(true, Listar());
            Assert.AreEqual(true, Borrar());
        }

        public bool Listar()
        {
            this.lista = this.iAplicacion!.Listar();
            return lista != null && lista.Count > 0;
        }

        public bool Guardar()
        {
            this.entidad = new Favoritos
            {
                UsuarioId = 1,
                AnuncioId = 1,
                FechaAgregado = DateTime.Now,
                Notas = "Favoritos de prueba",
                Activo = true
            };

            this.iAplicacion!.Guardar(this.entidad);
            return true;
        }

        public bool Modificar()
        {
            this.entidad!.Notas = "Favoritos modificado";
            this.iAplicacion!.Modificar(this.entidad);
            return true;
        }

        public bool Borrar()
        {
            this.iAplicacion!.Borrar(this.entidad!);
            return true;
        }
    }
}
