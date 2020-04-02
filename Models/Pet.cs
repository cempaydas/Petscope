using System;
using System.ComponentModel.DataAnnotations;
namespace prof_sofware.Models
{
    public class Pet
    {
        [Key]
        public int Id { get; set; }
         [Required]
        public string Name { get; set; }
         [Required]
        public Species Species { get; set; }
        
        public DateTime  BDate { get; set; }
         [Required]
        public User User { get; set; }
        public bool isActive { get; set; }
        
        public string Description { get; set; }

    }
}