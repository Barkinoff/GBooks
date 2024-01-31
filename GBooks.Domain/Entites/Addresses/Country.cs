

using GBooks.Domain.Commons;

namespace GBooks.Domain.Entites.Addresses;

public class Country : BaseEntity
{
    public string Name { get; set; }
    public string CountryCode { get; set; }
}
