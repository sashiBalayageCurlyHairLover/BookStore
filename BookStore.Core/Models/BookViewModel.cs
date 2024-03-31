using System.ComponentModel.DataAnnotations;
using static BookStore.Infrastructure.Data.DataConstants;

namespace BookStore.Core.Models
{
    public class BookViewModel
    {
        [Required]
        public int BookId { get; set; }

        [Required]
        [StringLength(MaxBookTitleLength, MinimumLength = MinBookTitleLength)]
        public string Title { get; set; } = string.Empty;

        [Required]
        [RegularExpression(ISBNPattern)]
        public string ISBN { get; set; } = string.Empty;

        [Required]
        [Range(MinBookPrice, MaxBookPrice)]
        public double Price { get; set; }
    }
}
