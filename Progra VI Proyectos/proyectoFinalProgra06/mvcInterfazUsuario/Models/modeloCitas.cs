using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mvcInterfazUsuario.Models
{
    public class modeloCitas
    {
        //Atributos a manipular
        [Display(Name = "Numero de Cita")]
        [Required(ErrorMessage = "El Numero de cita es requerido verifique...")]
        public int NumeroCita { get; set; }

        [Display(Name = "Codigo Cliente")]
        public Nullable<int> IDCliente { get; set; }

        [Display(Name = "Codigo Mascota")]
        public Nullable<int> IDMascota { get; set; }

        [Display(Name = "Fecha de la Cita")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyy}")]
        public Nullable<System.DateTime> FechaCita { get; set; }
    }
}