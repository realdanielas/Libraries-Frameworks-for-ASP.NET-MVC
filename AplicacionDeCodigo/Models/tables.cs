using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AplicacionDeCodigo.Models
{
    public class Ventas
    {
        [Key]
        public int id { get; set; }
        public DateTime fecha { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal monto { get; set; }
    }
}
