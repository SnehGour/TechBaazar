using System.ComponentModel.DataAnnotations;

namespace Server.Model
{
    public class Products
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Brand { get; set; }

        public string Category { get; set; } 
        [Required]
        public float Price { get; set; }
        public int CountInStock { get; set; }
        public float rating { get; set; }
        public int NumOfReviews { get; set; }
    }
}
