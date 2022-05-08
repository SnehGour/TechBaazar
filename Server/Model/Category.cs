using System.ComponentModel.DataAnnotations;

namespace Server.Model
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
