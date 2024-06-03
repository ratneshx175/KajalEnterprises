using System.ComponentModel.DataAnnotations;

namespace KajalEnterprises.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public double ListPrice { get; set; }
        [Required]
        public double RealPrice { get; set; }
    }
}
