using System.ComponentModel.DataAnnotations;
namespace prof_sofware.Models
{
    public class Genus
    {
        [Key]
        public int Id { get; set; }
         [Required]
        public string Value { get; set; }
    }
}