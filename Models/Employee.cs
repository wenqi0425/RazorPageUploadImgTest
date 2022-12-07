using Microsoft.AspNetCore.Http;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPageUploadImgTest.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageData { get; set; }

        [NotMapped]
        public IFormFile ImageFile { get; set; }
    }
}
