

using GBooks.Domain.Commons;

namespace GBooks.Domain.Entites.Users;

public class Role : BaseEntity
{
    public string Name { get; set; }

    public ICollection<RolePermission> Permissions { get; set; }
}
