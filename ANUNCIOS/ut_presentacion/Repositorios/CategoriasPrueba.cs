using lib_dominio.Entidades;
using lib_repositorios.Interfaces;
using lib_repositorios.Implementaciones;
using Microsoft.EntityFrameworkCore;
using ut_presentacion.Nucleo;

namespace ut_presentacion.Repositorios
{
    [TestClass]
    public class CategoriasPrueba
    {
        private readonly IConexion? iConexion;
        private List<Categorias>? lista;
        private Categorias? Categorias;

        public CategoriasPrueba()
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
            this.lista = this.iConexion!.Categorias!.ToList();
            return lista.Count > 0;
        }

        public bool Guardar()
        {
            this.Categorias = EntidadesNucleo.Categorias()!;
            this.iConexion!.Categorias!.Add(this.Categorias);
            this.iConexion!.SaveChanges();

            return true;
        }

        public bool Modificar()
        {
            this.Categorias!.Nombre = "Test";

            var entry = this.iConexion!.Entry<Categorias>(this.Categorias);
            entry.State = EntityState.Modified;
            this.iConexion!.SaveChanges();

            return true;
        }

        public bool Borrar()
        {
            this.iConexion!.Categorias!.Remove(this.Categorias!);
            this.iConexion!.SaveChanges();
            return true;
        }
    }
}

