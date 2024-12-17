using System.ComponentModel.DataAnnotations;

namespace MVCSistema.Models
{
    public class Venta
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Ingrese la fecha de la venta")]
        public DateTime Fecha { get; set; }

        [Required(ErrorMessage = "Ingrese el total de la venta")]
        public decimal Total { get; set; }

        [Required(ErrorMessage = "Seleccione el producto")]
        public int ProductoId { get; set; }
        public Producto? Producto { get; set; }

        [Required(ErrorMessage = "Seleccione el cliente")]
        public int ClienteId { get; set; }
        public Cliente? Cliente { get; set; }

    }
}
