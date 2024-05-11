using System.ComponentModel.DataAnnotations;

namespace Chulas.Models
{
    public class BlogPost
    {
        [Key]
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string Tag { get; set; }
        public DateOnly Date { get; set; }
    }
}
