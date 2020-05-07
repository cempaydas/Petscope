using System;
using System.ComponentModel.DataAnnotations;

namespace prof_sofware.Models
{
    public class Emergency
    {
        [Key]
        public int Id { get; set; }
        public string Image { get; set; }
         [Required]
        public string Location { get; set; }
         [Required]
        public string Description { get; set; }
         [Required]
        public User User { get; set; }
         [Required]
        public DateTime Date { get; set; }
         [Required]
        public Status Status { get; set; }
    }
}