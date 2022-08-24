using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mvcInterfazUsuario.Models
{
    public class modeloMascotas
    {
        //ATRIBUTOS QUE VOY A MANIPULAR 

        [Required(ErrorMessage = "El ID mascota es requerido verifique...")]
        [Display(Name = "Codigo de la Mascota")]
        public int IDMascota { get; set; }
        [Display(Name = "Nombre de la mascota")]
        public string Nombre { get; set; }
        [Display(Name = "Codigo del cliente")]

        public Nullable<int> IdCliente { get; set; }
    }
}