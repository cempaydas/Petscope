using System.ComponentModel.DataAnnotations;
namespace prof_sofware.Models
{
    public class Hospital
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
    }
}