
using GBooks.Domain.Commons;
using GBooks.Domain.Entites.Books;

namespace GBooks.Domain.Entites.Carts;

public class CartItem : BaseEntity
{
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public decimal TotalPrice { get; set;}
    public decimal DiscountPercent { get; set; }

    public long BookId { get; set; }
    public Book Book { get; set; }

    public long CartId { get; set; }
    public Cart Cart { get; set; }  
}
