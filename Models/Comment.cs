using System;
using System.ComponentModel.DataAnnotations;

namespace prof_sofware.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
         [Required]
        public Post Post { get; set; }
         [Required]
        public string CommentValue { get; set; }
         [Required]
        public DateTime Date { get; set; }
    }
}