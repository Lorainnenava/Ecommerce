using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Shared.Entities
{
    public class Country
    {
        [Key]
        public int CountryId { get; set; }

        [Display(Name = "País")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(100, ErrorMessage ="El campo {0} no puuede tener más de {1} caractéres")]
        public string Name { get; set; } = null!;
    }
}
