

using System.ComponentModel.DataAnnotations.Schema;

namespace lib_dominio.Entidades
{
    public class AnunciosSubcategorias
    {   public int Id { get; set; }
        public int AnuncioId { get; set; }   
        public int SubcategoriaId { get; set; }
        public DateTime FechaAsignacion { get; set; }
        public string? AsignadoPor { get; set; }

        [ForeignKey("AnuncioId")] public Anuncios? _Anuncio { get; set; }
        [ForeignKey("SubcategoriaId")] public Subcategorias? _Subcategoria { get; set; }
        

    }
}
