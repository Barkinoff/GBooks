

using GBooks.Domain.Commons;

namespace GBooks.Domain.Entites.Addresses;

public class Address : BaseEntity
{
    public string Distinct { get; set; }

    public string City { get; set; }

    public string Street { get; set; }

    public string? Floor { get; set; }

    public string Home { get; set; }

    public string DoorNumber { get; set; }

    public int PostCode { get; set; }

    public long CountryId { get; set; }

    public Country Country { get; set; }
}
