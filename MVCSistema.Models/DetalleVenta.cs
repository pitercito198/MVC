using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCSistema.Models
{
    public class DetalleVenta
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Seleccione la venta")]
        public int VentaId { get; set; }
        public Venta? Venta { get; set; }

        [Required(ErrorMessage = "Seleccione el producto")]
        public int ProductoId { get; set; }
        public Producto? Producto { get; set; }

        [Required(ErrorMessage = "Ingrese la cantidad")]
        public int Cantidad { get; set; }

        [Required(ErrorMessage = "Ingrese el precio unitario")]
        public decimal PrecioUnitario { get; set; }

        [Required(ErrorMessage = "Ingrese el subtotal")]
        public decimal Subtotal { get; set; }

    }
}
