using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Data
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string ISBN { get; set; } = string.Empty;

        [Required]
        public double Price { get; set; }

        [Required]
        [ForeignKey("Author")]
        public int AuthorId { get; set; }

        public Author Author { get; set; } = null!;

        [Required]
        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        public Category Category { get; set; } = null!;
    }
}
