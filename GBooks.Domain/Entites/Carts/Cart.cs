

using GBooks.Domain.Commons;
using GBooks.Domain.Entites.Users;

namespace GBooks.Domain.Entites.Carts;

public class Cart : BaseEntity
{
    public decimal TotalPrice { get; set; }

    public long UserId { get; set; }
    public User User { get; set; }
}
