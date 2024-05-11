using System.ComponentModel.DataAnnotations;

namespace Chulas.Models
{
    public class MenuItem
    {
        [Key]
        public int ItemId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
    }
}
