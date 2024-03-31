using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Data
{
    public class OrderDetail
    {
        [Key]
        public int OrderDetailId { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        [ForeignKey("Book")]
        public int BookId { get; set; }

        public Book Book { get; set; } = null!;

        [Required]
        [ForeignKey("Order")]
        public int OrderId { get; set; }

        public Order Order { get; set; } = null!;
    }
}
