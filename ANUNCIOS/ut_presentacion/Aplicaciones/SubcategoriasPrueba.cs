
using lib_dominio.Entidades;
using lib_repositorios.Implementaciones;
using lib_repositorios.Interfaces;
using ut_presentacion.Nucleo;
namespace ut_presentacion.Aplicaciones
{
    [TestClass]
    public class SubcategoriasPrueba
    {
        private readonly ISubcategoriasAplicacion? iAplicacion;
        private readonly IConexion? iConexion;
        private List<Subcategorias>? lista;
        private Subcategorias? entidad;

        public SubcategoriasPrueba()
        {
            iConexion = new Conexion();
            iConexion.StringConexion = Configuracion.ObtenerValor("StringConexion");
            iAplicacion = new SubcategoriasAplicacion(iConexion);
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
            this.entidad = new Subcategorias
            {
                Nombre = "Subcategoria Prueba",
                Descripcion = " Descrip SubCategoria prueba",
                CategoriaId = 1,
                FechaCreacion = DateTime.Now,
                Activo = true
            };

            this.iAplicacion!.Guardar(this.entidad);
            return true;
        }

        public bool Modificar()
        {
            this.entidad!.Nombre = "Subcategorias modificado";
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

