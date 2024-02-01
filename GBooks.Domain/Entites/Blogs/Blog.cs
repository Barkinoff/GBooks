
using GBooks.Domain.Commons;
using GBooks.Domain.Entites.Attachments;
using GBooks.Domain.Entites.Books;
using GBooks.Domain.Entites.Users;

namespace GBooks.Domain.Entites.Blogs;

public class Blog : BaseEntity
{
    public string Title { get; set; }
    public string Description { get; set;}

    public long AttachmentId { get; set; }
    public Attachment Attachment { get; set; }
}
