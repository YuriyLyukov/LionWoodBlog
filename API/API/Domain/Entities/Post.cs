using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Domain.Entities
{
    public class Post
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]

        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public DateTime Date { get; set; } = DateTime.UtcNow;
        [Required]
        public string AuthorName { get; set; }

        public string Tags { get; set; }
    }
}