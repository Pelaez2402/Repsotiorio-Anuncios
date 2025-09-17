using System.ComponentModel.DataAnnotations.Schema;

namespace lib_dominio.Entidades
{
    public class Categorias
    {
        public int Id { get; set; } 
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public byte Activo { get; set; }


        [ForeignKey("Subcategoria")] public Subcategorias? _Subcategoria { get; set; }
    }
}

