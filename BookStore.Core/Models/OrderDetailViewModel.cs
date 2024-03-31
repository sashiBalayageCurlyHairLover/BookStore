using System.ComponentModel.DataAnnotations;
using static BookStore.Infrastructure.Data.DataConstants;

namespace BookStore.Core.Models
{
    public class OrderDetailViewModel
    {
        [Required]
        public int OrderDetailId { get; set; }

        [Required]
        [Range(MinOrderQuantity, MaxOrderQuantity)]
        public int Quantity { get; set; }

        [Required]
        [Range(MinOrderQuantity * MinBookPrice, (MaxOrderQuantity * MaxBookPrice) + 1)]
        public double Price { get; set; }
    }
}
