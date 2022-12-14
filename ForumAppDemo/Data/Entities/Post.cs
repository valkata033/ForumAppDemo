using System.ComponentModel.DataAnnotations;
using static ForumAppDemo.Data.DataConstants.Post;

namespace ForumAppDemo.Data.Entities
{
    public class Post
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(TitleMaxLength)]
        public string Title { get; set; } = null!;

        [Required]
        [StringLength(ContentMaxLength)]
        public string Content { get; set; } = null!;

        [Required]
        public bool IsDeleted { get; set; } = false;
    }
}
