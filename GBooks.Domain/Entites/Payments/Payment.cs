
using GBooks.Domain.Commons;
using GBooks.Domain.Enums;

namespace GBooks.Domain.Entites.Payments;

public class Payment : BaseEntity
{
    public PaymentType PaymentType { get; set; }
    public decimal PayAmount { get; set; }
}
