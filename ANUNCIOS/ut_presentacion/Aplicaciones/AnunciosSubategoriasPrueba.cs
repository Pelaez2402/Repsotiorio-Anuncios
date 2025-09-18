
using lib_dominio.Entidades;
using lib_repositorios.Implementaciones;
using lib_repositorios.Interfaces;
using ut_presentacion.Nucleo;
namespace ut_presentacion.Aplicaciones
{
    [TestClass]
 
    public class AnunciosSubcategoriasPrueba
    {
        private readonly IAnunciosSubcategoriasAplicacion? iAplicacion;
        private readonly IConexion? iConexion;
        private List<AnunciosSubcategorias>? lista;
        private AnunciosSubcategorias? entidad;

        public AnunciosSubcategoriasPrueba()
        {
            iConexion = new Conexion();
            iConexion.StringConexion = Configuracion.ObtenerValor("StringConexion");
            iAplicacion = new AnunciosSubcategoriasAplicacion(iConexion);
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
            this.entidad = new AnunciosSubcategorias
            {
                AnuncioId = 1,
                SubcategoriaId = 1,
                FechaAsignacion = DateTime.Now,
                AsignadoPor = "AnunciosSubcategoriasPrueba..."
            };

            this.iAplicacion!.Guardar(this.entidad);
            return true;
        }

        public bool Modificar()
        {
            this.entidad!.AsignadoPor = "AnuncioSubca modificado";
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
