

using GBooks.Domain.Commons;
using GBooks.Domain.Entites.Attachments;
using GBooks.Domain.Entites.Categories;
using GBooks.Domain.Entites.Discounts;

namespace GBooks.Domain.Entites.Books;

public class Book : BaseEntity
{
    public string Name { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Publisher { get; set; }
    public string PublicationDate { get; set; }
    public string Format { get; set; }
    public int IBSN { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }

    public long AuthorId { get; set; }
    public Author Author { get; set; }

    public long AttachmentId { get; set; }
    public Attachment Attachment { get; set; }

    public long LanguageId { get; set; }
    public Language Language { get; set; }

    public long? DiscountId { get; set; }
    public Discount? Discount { get; set; }

    public long SubCategoryId { get; set; }
    public SubCategory SubCategory { get; set; }
}
