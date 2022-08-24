using System.ComponentModel.DataAnnotations;

namespace mvcInterfazUsuario.Models
{
    public class modeloCountryRegion
    {
        [Required(ErrorMessage = "El código de región es requerido verifique...")]
        [Display(Name = "Código de región")]
        public string CountryRegionCode { get; set; }

        [Required(ErrorMessage = "El nombre de región es requerido verifique...")]
        [Display(Name = "Nombre de región")]
        //[MaxLength(50, ErrorMessage ="")]
        //[MinLength(10, ErrorMessage ="")]
        //[Range(1,10)]
        [StringLength(50, MinimumLength = 10, ErrorMessage = "El nombre debe tener 10 caracteres como mínimo y 50 como máximo")]
        public string Name { get; set; }

        [Required(ErrorMessage = "La fecha de modificación de región es requerida verifique...")]
        [Display(Name = "Fecha de modificación")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public System.DateTime ModifiedDate { get; set; }

    }
}