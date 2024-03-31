using System.ComponentModel.DataAnnotations;

namespace BookStore.Data
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        public ICollection<Book> Books { get; set; } = new List<Book>();
    }
}
