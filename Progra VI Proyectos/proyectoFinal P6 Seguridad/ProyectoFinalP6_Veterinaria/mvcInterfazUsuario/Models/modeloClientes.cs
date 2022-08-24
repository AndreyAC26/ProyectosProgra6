using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mvcInterfazUsuario.Models
{
    public class modeloClientes
    {
        //ATRIBUTOS QUE VOY A MANIPULAR 
        [Required(ErrorMessage = "El ID cliente es requerido verifique...")]
        [Display(Name = "Codigo del cliente")]
        public int IDCliente { get; set; }
        ///MaxLength(50, ErrorMessage ="")]
        ///MinLength(10, ErrorMessage ="")]
        [Display(Name = "Nombre del cliente")]
        [StringLength(50, MinimumLength = 10, ErrorMessage = "El nombre debe de tener 10 caracteres como minimo y 50 como maximo")]
        public string Nombre { get; set; }
        [Display(Name = "Primer Apellido")]
        public string PrimerApellido { get; set; }
        [Display(Name = "Segundo Apellido")]
        public string SegundoApellido { get; set; }
        public Nullable<decimal> Telefono { get; set; }
        [Display(Name = "Correo ")]
        public string CorreoElectronico { get; set; }
    }
}