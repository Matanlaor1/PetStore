using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetStore.Models
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        [ForeignKey("AnimalId")]
        public int AnimalId { get; set; }
        [Required]
        [StringLength(200, MinimumLength = 5, ErrorMessage = "Comment should be more then 5 chars and less then 200")]
        public string? Content { get; set; }

        public static int commentID = 35;
    }
}
