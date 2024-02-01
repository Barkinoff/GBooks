using GBooks.Domain.Commons;


namespace GBooks.Domain.Entites.Languages
{
    public class Language : BaseEntity
    {
        public string Name { get; set; }
        public string LanguageCode { get; set; }
    }
}
