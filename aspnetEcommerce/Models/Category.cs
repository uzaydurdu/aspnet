using System.ComponentModel.DataAnnotations;

namespace aspnetEcommerce.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int OrderCount { get; set; }
    }
}
