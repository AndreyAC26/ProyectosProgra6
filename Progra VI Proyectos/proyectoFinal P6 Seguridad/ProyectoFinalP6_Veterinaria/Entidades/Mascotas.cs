//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entidades
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Mascotas
    {
        [Required(ErrorMessage = "El ID mascota es requerido verifique...")]
        [Display(Name ="Codigo de la Mascota")]
         
        public int IDMascota { get; set; }
        [Display(Name = "Nombre de la mascota")]
        public string Nombre { get; set; }
        [Display(Name = "Codigo del cliente")]
        public Nullable<int> IdCliente { get; set; }
    }
}
