

using GBooks.Domain.Commons;
using GBooks.Domain.Enums;

namespace GBooks.Domain.Entites.Users;

public class RolePermission : BaseEntity
{
    public long RoleId { get; set; }

    public Role Role { get; set; }

    public Permission Permission { get; set; }
}
