using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MicroSource.Api.Models
{
    [Table("Product")]

    public class Product : Base
    {
        [MaxLength(255)]
        [Display(Name = "Descrição")]
        public string Description { get; set; }

        [Required]
        [Range(1, 10000)]
        [Display(Name = "Preço")]
        public float Price { get; set; }

        [MaxLength(255)]
        [Display(Name = "Foto")]
        public string Img { get; set; }
    }
}
