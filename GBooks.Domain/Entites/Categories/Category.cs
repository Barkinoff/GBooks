
using GBooks.Domain.Commons;

namespace GBooks.Domain.Entites.Categories;

public class Category : BaseEntity
{
    public string Title { get; set; }

    public string Description { get; set; }

    public long? ParentId { get; set; }
    public Category? ParentCategory { get; set; }

    public long? SubCategoryId { get; set; }
    public SubCategory? SubCategory { get; set; }
}
