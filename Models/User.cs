using System.ComponentModel.DataAnnotations;
namespace prof_sofware.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
         [Required]
        public string UserName { get; set; }
         [Required]
        public string Name { get; set; }
         [Required]
        public string Password { get; set; }
         [Required]
        public bool isActive { get; set; }
         [Required]
        public string Phone { get; set; }
         [Required]
        public string Email {get;set;}
        
        public UserType UserType { get; set; }
    }
}