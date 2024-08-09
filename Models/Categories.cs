using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetStore.Models
{
    public class Categories
    {
        [Key]
        public int CategoryId { get; set; }
        public string? Name { get; set; }
    }
}
