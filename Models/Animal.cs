using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetStore.Models
{
    public class Animal
    {
        [Key]
        public int AnimalId { get; set; }
        [StringLength(10, MinimumLength = 3, ErrorMessage = "Name must be 3 to 10 letters")]
        public string? Name { get; set; }
        [Range(0, 120, ErrorMessage = "Must be above 0 and below 120")]
        public int Age { get; set; }
        [DataType(DataType.Text)]
        public string? ImagePath { get; set; }
        [StringLength(200, MinimumLength = 10, ErrorMessage = "Description must be 10-200 chars")]
        [DataType(DataType.MultilineText)]
        public string? Description { get; set; }
        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }
        public List<Comment>? Comments { get; set; }


    }
}
