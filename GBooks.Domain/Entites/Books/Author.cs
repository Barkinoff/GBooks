

using GBooks.Domain.Commons;
using GBooks.Domain.Entites.Attachments;

namespace GBooks.Domain.Entites.Books;

public class Author : BaseEntity
{
    public string FullName { get; set; }
    public string Description { get; set; }

    public ICollection<Book> AuthorBooks { get; set; }

    public long AttachmentId { get; set; }
    public Attachment Attachment { get; set; }
 }
