using System.ComponentModel.DataAnnotations;

namespace mvcInterfazUsuario.Models
{
    public class modeloCountryRegion
    {
        [Required(ErrorMessage = "El Código de Región es requerido verifique...")]
        [Display(Name = "Código de region")]
        public string CountryRegionCode { get; set; }

        [Required(ErrorMessage = "El nombre de Región es requerido verifique...")]
        [Display(Name = "Nombre de region")]
        // [MaxLength(50, ErrorMessage = "El nombre contiene demaciados caracteres|")]
        // [MinLength(10, ErrorMessage = "El nombre no tiene suficientes caracteres")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "El nombre debe tener 10 como minimo y 50 caracteres como maximo.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "La fecha de modificacion de region es requerido...")]
        [Display(Name = "Fecha de modificación")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public System.DateTime ModifiedDate { get; set; }

    }
}