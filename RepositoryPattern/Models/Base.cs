using System.ComponentModel.DataAnnotations;

namespace MicroSource.Api.Models
{
    public class Base
    {
        public Guid Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
    }
}
