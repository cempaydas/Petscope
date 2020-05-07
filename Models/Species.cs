using System.ComponentModel.DataAnnotations;
namespace prof_sofware.Models
{
    public class Species
    {
        [Key]
        public int Id { get; set; }
         [Required]
        public Genus Genus { get; set; }
         [Required]
        public string Value { get; set; }
    }
}