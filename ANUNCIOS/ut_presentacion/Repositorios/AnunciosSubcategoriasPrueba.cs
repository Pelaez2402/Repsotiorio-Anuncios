using lib_dominio.Entidades;
using lib_repositorios.Interfaces;
using lib_repositorios.Implementaciones;
using Microsoft.EntityFrameworkCore;
using ut_presentacion.Nucleo;

namespace ut_presentacion.Repositorios
{
    [TestClass]
    public class AnunciosSubcategoriasPrueba
    {
        private readonly IConexion? iConexion;
        private List<AnunciosSubcategorias>? lista;
        private AnunciosSubcategorias? entidad;

        public AnunciosSubcategoriasPrueba()
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
            this.lista = this.iConexion!.AnunciosSubcategorias!.ToList();
            return lista.Count > 0;
        }

        public bool Guardar()
        {
            this.entidad = EntidadesNucleo.AnunciosSubcategorias()!;

            this.iConexion!.AnunciosSubcategorias!.Add(this.entidad);
            this.iConexion!.SaveChanges();

            return true;
        }

        public bool Modificar()
        {
            this.entidad!.AsignadoPor = "Test";

            var entry = this.iConexion!.Entry < AnunciosSubcategorias > (this.entidad);
            entry.State = EntityState.Modified;
            this.iConexion!.SaveChanges();

            return true;
        }

        public bool Borrar()
        {
            this.iConexion!.AnunciosSubcategorias!.Remove(this.entidad!);
            this.iConexion!.SaveChanges();
            return true;
        }
    }


}

