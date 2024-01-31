

using GBooks.Domain.Commons;
using GBooks.Domain.Entites.Addresses;

namespace GBooks.Domain.Entites.Users;

public class User : BaseEntity
{
    public string FirstName { get; set; }   

    public string LastName { get; set; }

    public string Email { get; set; }

    public string Password { get; set; }

    public string PhoneNumber { get; set; }

    public long? RoleId { get; set; }
    public Role? Role { get; set; }

    public long AddressId { get; set; } 
    public Address Address { get; set; }
}
