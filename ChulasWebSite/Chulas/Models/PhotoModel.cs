using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Chulas.Models
{
    public class PhotoModel
    {
        [Key]
        public int PhotoId { get; set; }
        public string PhotoName { get; set; }
        public string PhotoDescription { get; set; }
        public byte[] Photo { get; set; }
    }
}