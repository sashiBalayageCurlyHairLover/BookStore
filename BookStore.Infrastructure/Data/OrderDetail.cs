using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Data
{
    public class OrderDetail
    {
        [Key]
        public int OrderDetailId { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        // Navigation properties
        [ForeignKey("Book")]
        public int BookId { get; set; }
        public Book Book { get; set; } = null!;
        [ForeignKey("Order")]
        public int OrderId { get; set; }
        public Order Order { get; set; } = null!;
    }
}
