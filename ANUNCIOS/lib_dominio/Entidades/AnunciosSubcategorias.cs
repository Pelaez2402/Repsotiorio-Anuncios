

using System.ComponentModel.DataAnnotations.Schema;

namespace lib_dominio.Entidades
{
    public class AnunciosSubcategorias
    {
        public int AnuncioId { get; set; }   
        public int SubcategoriaId { get; set; }
        public DateTime FechaAsignacion { get; set; }
        public string? AsignadoPor { get; set; }

        [ForeignKey("Usuario")] public Usuarios? _Usuario { get; set; }
        [ForeignKey("Subcategoria")] public Subcategorias? Subcategoria { get; set; }
        

    }
}
