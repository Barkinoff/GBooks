
using GBooks.Domain.Commons;

namespace GBooks.Domain.Entites.Attachments;

public class Attachment : BaseEntity
{
    public string Name { get; set; }

    public string Path { get; set; }
}
