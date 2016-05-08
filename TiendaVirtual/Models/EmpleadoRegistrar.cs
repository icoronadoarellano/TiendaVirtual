using TiendaVirtual.Anotaciones;
using System.ComponentModel.DataAnnotations;

namespace TiendaVirtual.Models
{
    public class EmpleadoRegistrar
    {
        [Display( Name ="Empleado_Nombre", ResourceType= typeof(Seguridad.Recursos.Empleado))]
        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Apellidos { get; set; }
        [Required]
        public string Cargo { get; set; }

        [Required]
        public decimal Sueldo { get; set; }

        //[MaximoDescuento("Sueldo",50)]
        public decimal Descuentos { get; set; }
    }
}
