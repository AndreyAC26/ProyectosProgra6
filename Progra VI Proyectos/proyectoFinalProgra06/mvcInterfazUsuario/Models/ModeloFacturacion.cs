using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mvcInterfazUsuario.Models
{
    public class ModeloFacturacion   
    {
        [Required]
        [Display(Name = "Numero de Factura")]

        public int NumeroFactura { get; set; }

        [Required]
        [Display(Name = "Descipcion")]

        public string Descripcion { get; set; }

        [Required]
        [Display(Name = "Numero de Cita ")]

        public Nullable<int> NumeroCita { get; set; }

        [Required]
        [Display(Name = "Nombre del Cliente")]

        public string NombreCliente { get; set; }

        [Required]
        [Display(Name = "Nombre de la Mascota")]

        public string NombreMascota { get; set; }

        [Required]
        [Display(Name = "Fecha de la cita")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyy}")]
        public Nullable<System.DateTime> FechaCita { get; set; }

        [Required]
        [Display(Name = "Codigo del Servicio")]

        public Nullable<int> IdServicio { get; set; }
    }
}