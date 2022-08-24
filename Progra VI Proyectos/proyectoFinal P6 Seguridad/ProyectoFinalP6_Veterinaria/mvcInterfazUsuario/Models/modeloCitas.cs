using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mvcInterfazUsuario.Models
{
    public class modeloCitas
    {
        //ATRIBUTOS QUE VOY A MANIPULAR 
        [Required(ErrorMessage = "El Numero de cita es requerido verifique...")]
        [Display(Name = "Numero de cita")]
        public int NumeroCita { get; set; }
        [Display(Name = "Codigo del cliente")]
        public Nullable<int> IDCliente { get; set; }
        [Display(Name = "Codigo de la Mascota")]
        public Nullable<int> IDMascota { get; set; }
        [Display(Name = "Fecha cita")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyy}")]
        public Nullable<System.DateTime> FechaCita { get; set; }
    }
}