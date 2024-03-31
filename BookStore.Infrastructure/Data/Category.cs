using System.ComponentModel.DataAnnotations;

namespace BookStore.Data
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        public string Name { get; set; } = string.Empty;

        public ICollection<Book> Books { get; set; } = new List<Book>();
    }
}
