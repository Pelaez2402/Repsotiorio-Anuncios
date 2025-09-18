
using lib_dominio.Entidades;
using lib_repositorios.Implementaciones;
using lib_repositorios.Interfaces;
using ut_presentacion.Nucleo;

namespace ut_presentacion.Aplicaciones
{
    [TestClass]

    public class AnunciosPrueba
    {
        private readonly IAnunciosAplicacion? iAplicacion;
        private readonly IConexion? iConexion;
        private List<Anuncios>? lista;
        private Anuncios? entidad;

        public AnunciosPrueba()
        {
            iConexion = new Conexion();
            iConexion.StringConexion = Configuracion.ObtenerValor("StringConexion");
            iAplicacion = new AnunciosAplicacion(iConexion);
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
            this.entidad = new Anuncios
            {
                Titulo = "Anuncio de prueba",
                Descripcion = "Este es un anuncio de prueba para test unitario.",
                Precio = 100000,
                UsuarioId = 1,         
                UbicacionId = 1,       
                PlanId = null,         
                Estado = true
            };

            this.iAplicacion!.Guardar(this.entidad);
            return true;
        }

        public bool Modificar()
        {
            this.entidad!.Titulo = "Anuncio modificado";
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

