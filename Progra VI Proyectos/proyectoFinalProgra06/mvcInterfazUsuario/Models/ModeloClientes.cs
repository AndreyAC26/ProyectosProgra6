using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mvcInterfazUsuario.Models
{
    public class ModeloClientes
    {
        
        [Display(Name = "Numero de Cliente")]
        public int IDCliente { get; set; }


        [Required(ErrorMessage = "El Nombre es requerido verifique...")]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El Primer Apellido es requerido verifique...")]
        [Display(Name = "PrimerApellido")]
        //[StringLength(50, MinimumLength = 4, ErrorMessage = "El Primer Apellido debe tener 5 caracteres como mínimo y 20 como máximo")]
        public string PrimerApellido { get; set; }

        [Required(ErrorMessage = "El segundo Apellido es requerido verifique...")]
        [Display(Name = "SegundoApellido")]
       // [StringLength(50, MinimumLength = 10, ErrorMessage = "El Segundo Apellido debe tener 5 caracteres como mínimo y 20 como máximo")]

        public string SegundoApellido { get; set; }

        [Display(Name = "Telefono")]
        public int Telefono { get; set; }

        [Required]
        [Display (Name = "CorreoElectronico")]
        public string CorreoElectronico { get; set; }


    }
}