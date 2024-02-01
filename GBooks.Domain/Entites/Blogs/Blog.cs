using GBooks.Domain.Commons;
using GBooks.Domain.Entites.Attachments;
using GBooks.Domain.Entites.Languages;

namespace GBooks.Domain.Entites.Blogs;

public class Blog : BaseEntity
{
    public string Title { get; set; }
    public string Description { get; set;}

    public long AttachmentId { get; set; }
    public Attachment Attachment { get; set; }

    public long LanguageId { get; set; }
    public Language Language { get; set; }
}
