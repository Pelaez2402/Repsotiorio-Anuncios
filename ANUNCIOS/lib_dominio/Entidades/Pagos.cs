
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace lib_dominio.Entidades
{
    public class Pagos
    {
        public int Id { get; set; }
        public Decimal Monto { get; set; }
        public int UsuarioId { get; set; }
        public int PlanId { get; set; }
        public int AnuncioId { get; set; }    
        public DateTime FechaPago { get; set; }
        public string? MetodoPago { get; set; }
        public string? Estado { get; set; }

        [ForeignKey("UsuarioId")] public Usuarios? _Usuario { get; set; }
        [ForeignKey("AnuncioId")] public Anuncios? _Anuncio { get; set; }
        [ForeignKey("PlanId")] public PlanesDePublicacion? _PlanDePublicacion{ get; set; }


    }
}
