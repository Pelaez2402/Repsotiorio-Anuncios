using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace lib_dominio.Entidades
{
    public  class Anuncios
    {
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public string? Descripcion { get; set; }
        public decimal Precio { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public int UsuarioId { get; set; }
        public int UbicacionId { get; set; }
        public byte Estado { get; set; }
        public int PlanId { get; set; }

        [ForeignKey("Usuario")] public Usuarios? _Usuario { get; set; }
        [ForeignKey("Ubicacion")] public Ubicaciones? _Ubicacion { get; set; }
        [ForeignKey("PlanDePublicacion")] public PlanesDePublicacion? _PlanDePublicacion { get; set; }

    }
}
