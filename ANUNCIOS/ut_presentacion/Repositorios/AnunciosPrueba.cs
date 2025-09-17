
using lib_dominio.Entidades;
using lib_repositorios.Interfaces;
using lib_repositorios.Implementaciones;
using Microsoft.EntityFrameworkCore;
using ut_presentacion.Nucleo;
namespace ut_presentacion.Repositorios
{
    [TestClass]
    public class AnunciosPrueba
    {
        private readonly IConexion? iConexion;
        private List<Anuncios>? lista;
        private Anuncios? entidad;

        public AnunciosPrueba()
        {
            iConexion = new Conexion();
            iConexion.StringConexion = Configuracion.ObtenerValor("StringConexion");
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
            this.lista = this.iConexion!.Anuncios!.ToList();
            return lista.Count > 0;
        }

        public bool Guardar()
        {
            this.entidad = EntidadesNucleo.Anuncios()!;

            this.iConexion!.Anuncios!.Add(this.entidad);
            this.iConexion!.SaveChanges();

            return true;
        }

        public bool Modificar()
        {
            this.entidad!.Titulo = "Test";

            var entry = this.iConexion!.Entry<Anuncios>(this.entidad);
            entry.State = EntityState.Modified;
            this.iConexion!.SaveChanges();

            return true;
        }

        public bool Borrar()
        {
            this.iConexion!.Anuncios!.Remove(this.entidad!);
            this.iConexion!.SaveChanges();
            return true;
        }




    }
}
