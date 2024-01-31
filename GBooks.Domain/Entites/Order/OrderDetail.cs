

using GBooks.Domain.Commons;
using GBooks.Domain.Entites.Books;
using GBooks.Domain.Entites.Carts;

namespace GBooks.Domain.Entites.Order;

public class OrderDetail : BaseEntity
{
    public int Quantity { get; set; }
    public decimal Price { get; set; }
    public decimal? DiscountPercent { get; set; }
    public decimal TotalPrice { get; set; }

    public long BookId { get; set; }
    public Book Book { get; set; }

    public long CartItemId { get; set; }
    public CartItem CartItem { get; set; }
}
