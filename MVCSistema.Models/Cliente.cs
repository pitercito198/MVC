using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCSistema.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Ingrese el nombre del cliente")]
        [Display(Name = "Nombre del Cliente")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "Ingrese el apellido del cliente")]
        public string? Apellido { get; set; }

        [Required(ErrorMessage = "Ingrese el email del cliente")]
        [EmailAddress(ErrorMessage = "Ingrese un email válido")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Ingrese el teléfono del cliente")]
        public string? Telefono { get; set; }

        [Required(ErrorMessage = "Ingrese la dirección del cliente")]
        public string? Direccion { get; set; }

    }
}
