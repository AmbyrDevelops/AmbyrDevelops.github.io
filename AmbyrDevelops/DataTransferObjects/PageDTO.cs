using System.ComponentModel.DataAnnotations;

namespace AmbyrDevelops.DataTransferObjects
{
    public class PageDTO
    {
        [Key]
        public int Id { get; set; }
        public string? Type { get; set; }
        [Required]
        public required string Section { get; set; }
        public string? Title { get; set; }
        public string? Subtitle { get; set; }
        public string? Excerpt { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public string? Video { get; set; }
        public string? Link { get; set; }
    }
}
