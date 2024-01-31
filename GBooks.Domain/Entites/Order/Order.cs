

using GBooks.Domain.Commons;
using GBooks.Domain.Entites.Addresses;
using GBooks.Domain.Entites.Payments;
using GBooks.Domain.Entites.Supliers;
using GBooks.Domain.Entites.Users;
using GBooks.Domain.Enums;

namespace GBooks.Domain.Entites.Order;

public class Order : BaseEntity
{
    public decimal TotalPrice { get; set; }
    public Status Status { get; set; }
    public decimal DeliveryFee { get; set; }
    public DateTime DeliveryDay { get; set; }

    public long UserId { get; set; }
    public User User { get; set; }

    public long AddressId { get; set; }
    public Address Address { get; set; }

    public long SuplierId { get; set; }
    public Suplier Suplier { get; set; }

    public long PaymentId { get; set; }
    public Payment Payment { get; set; }
}
