using System.ComponentModel.DataAnnotations;
namespace prof_sofware.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
         [Required]
        public Pet Pet { get; set; }
         [Required]
        public string Description { get; set; }
         [Required]
        public string  ImagePath { get; set; }
        public string Location { get; set; }
    }
}