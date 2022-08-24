using System.ComponentModel.DataAnnotations;

namespace mvcInterfazUsuario.Models
{
    public class modeloDepartment
    {
        [Required(ErrorMessage = "El código de Departamento es requerido verifique...")]
        [Display(Name = "Código de Departamento")]
        public short DepartmentID { get; set; }

        [Required(ErrorMessage = "El nombre de Departamento es requerido verifique...")]
        [Display(Name = "Departamento")]
        //[MaxLength(50, ErrorMessage ="")]
        //[MinLength(10, ErrorMessage ="")]
        //[Range(1,10)]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "El nombre debe tener 10 caracteres como mínimo y 50 como máximo")]
        public string Name { get; set; }

        [Required(ErrorMessage = "El nombre del Grupo de Departamento es requerido verifique...")]
        [Display(Name = "Nombre del Grupo")]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "El nombre debe tener 10 caracteres como mínimo y 50 como máximo")]
        public string GroupName { get; set; }


        [Required(ErrorMessage = "La fecha de modificación de Departamento es requerida verifique...")]
        [Display(Name = "Fecha de modificación")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public System.DateTime ModifiedDate { get; set; }
    }
}