
using GBooks.Domain.Commons;
using GBooks.Domain.Entites.Attachments;

namespace GBooks.Domain.Entites.Discounts;

public class Discount : BaseEntity
{
    public string Title { get; set; }

    public string Description { get; set; } 

    public decimal Percent { get; set; }

    public long AttachmentId { get; set; }
    public Attachment Attachment { get; set; }
}
