using System.ComponentModel.DataAnnotations.Schema;

namespace lib_dominio.Entidades
{
    public class Subcategorias
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public int CategoriaId { get; set; }
        public DateTime FechaCreacion { get; set; }
        public bool Activo { get; set; }

        public List<Categorias> _Categoria { get; set; } = new List<Categorias>();
        public List<AnunciosSubcategorias> AnunciosSubcategorias { get; set; } = new List<AnunciosSubcategorias>();


    }
}
