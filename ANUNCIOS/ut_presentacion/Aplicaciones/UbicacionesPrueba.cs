
using lib_dominio.Entidades;
using lib_repositorios.Implementaciones;
using lib_repositorios.Interfaces;
using ut_presentacion.Nucleo;
namespace ut_presentacion.Aplicaciones
{
    [TestClass]
    public class UbicacionesPrueba
    {
        private readonly IUbicacionesAplicacion? iAplicacion;
        private readonly IConexion? iConexion;
        private List<Ubicaciones>? lista;
        private Ubicaciones? entidad;

        public UbicacionesPrueba()
        {
            iConexion = new Conexion();
            iConexion.StringConexion = Configuracion.ObtenerValor("StringConexion");
            iAplicacion = new UbicacionesAplicacion(iConexion);
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
            this.entidad = new Ubicaciones
            {
                Nombre = "Ubicacion Prueba",
                Direccion = "Prueba",
                Ciudad = "Prueba",
                Pais = "Prueba"
            };

            this.iAplicacion!.Guardar(this.entidad);
            return true;
        }

        public bool Modificar()
        {
            this.entidad!.Nombre = "Ubicaciones modificado";
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
