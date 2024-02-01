
using GBooks.Domain.Commons;
using GBooks.Domain.Entites.Books;
using GBooks.Domain.Entites.Users;

namespace GBooks.Domain.Entites.Feedbacks;

public class Feedback : BaseEntity
{
    public string Text { get; set; }

    public long BookId { get; set; }
    public Book Book { get; set; }

    public long UserId { get; set; }
    public User User { get; set; }
}
