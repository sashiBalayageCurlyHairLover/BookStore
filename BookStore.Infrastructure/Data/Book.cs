using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Data
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }

        public string Title { get; set; } = string.Empty;

        public string ISBN { get; set; } = string.Empty;

        public double Price { get; set; }

        [ForeignKey("Author")]
        public int AuthorId { get; set; }

        public Author Author { get; set; } = null!;

        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        public Category Category { get; set; } = null!;
    }
}
