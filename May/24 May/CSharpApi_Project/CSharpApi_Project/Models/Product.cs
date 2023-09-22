using System.ComponentModel.DataAnnotations;

namespace CSharpApi_Project.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        [StringLength(30)]  
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
