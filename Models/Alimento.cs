using Lab12YG.Models;
using Lab12YG.Validations;

using System.ComponentModel.DataAnnotations;

namespace Lab12YG.Models
{
    public class Alimento : Producto
    {
        [Required]
        [Display(Name = "Fecha de Vencimiento")]
        [FechaMayorAHoy] // Validación personalizada
        public DateTime FechaVencimiento { get; set; }

        [Required]
        [Display(Name = "Unidad de Medida")]
        public string UnidadMedida { get; set; }

    }
}
