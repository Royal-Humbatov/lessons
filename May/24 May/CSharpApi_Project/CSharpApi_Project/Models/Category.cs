using System.ComponentModel.DataAnnotations;

namespace CSharpApi_Project.Models
{
    public class Category
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }
        public virtual ICollection<Product> Products { get; set; } 

    }
}
