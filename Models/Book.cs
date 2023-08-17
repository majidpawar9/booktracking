using System.ComponentModel.DataAnnotations;

namespace booktracking.Models
{
    public class Book
    {
        [Key] // This marks the ISBN property as the primary key
        public string ISBN { get; set; }
        
        [Required]
        public string Title { get; set; }
        
        [Required]
        public int CategoryId { get; set; } // Foreign key to Category
        public Category Category { get; set; } // Navigation property to Category
        
        [Required]
        public string Author { get; set; }

    }
}
