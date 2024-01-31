

using GBooks.Domain.Commons;
using GBooks.Domain.Entites.Books;

namespace GBooks.Domain.Entites.Categories;

public class SubCategory : BaseEntity
{
    public string Title { get; set; }
    public string Description { get; set; }

    public ICollection<Book> Books { get; set; }
}
