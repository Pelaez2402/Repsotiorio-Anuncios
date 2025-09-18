
using lib_dominio.Entidades;
using lib_repositorios.Implementaciones;
using lib_repositorios.Interfaces;
using ut_presentacion.Nucleo;

namespace ut_presentacion.Aplicaciones
{
    [TestClass]
   
    public class ReportesDeAnunciosPrueba
    {
        private readonly IReportesDeAnunciosAplicacion? iAplicacion;
        private readonly IConexion? iConexion;
        private List<ReportesDeAnuncios>? lista;
        private ReportesDeAnuncios? entidad;

        public ReportesDeAnunciosPrueba()
        {
            iConexion = new Conexion();
            iConexion.StringConexion = Configuracion.ObtenerValor("StringConexion");
            iAplicacion = new ReportesDeAnunciosAplicacion(iConexion);
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
            this.entidad = new ReportesDeAnuncios
            {
                Motivo = "Reporte de prueba",
                FechaReporte = DateTime.Now,
                UsuarioId = 1,
                AnuncioId = 1,
                Estado = "Estado de prueba REVISADO"
            };

            this.iAplicacion!.Guardar(this.entidad);
            return true;
        }

        public bool Modificar()
        {
            this.entidad!.Motivo = "ReportesDeAnuncios modificado";
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
