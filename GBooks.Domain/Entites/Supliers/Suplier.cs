
using GBooks.Domain.Commons;
using GBooks.Domain.Entites.Attachments;
using GBooks.Domain.Enums;

namespace GBooks.Domain.Entites.Supliers;

public class Suplier : BaseEntity
{ 
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Phone { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Vehicle { get; set; }
    public Gender Gender { get; set; }
   

    public long? AttachmentId { get; set; }
    public Attachment Attachment { get; set; }
}
