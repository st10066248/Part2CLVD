using System.ComponentModel.DataAnnotations;

namespace Part2CLVD.Models
{
    public class ProductDto
    {
        [Required]
        public string Name { get; set; } = "";

        [Required]
        public string Description { get; set; } = "";

        [Required]
        public string Category { get; set; } = "";

        [Required]
        public decimal Price { get; set; }

        [Required]
        public string Availibility { get; set; } = "";

    }
}
