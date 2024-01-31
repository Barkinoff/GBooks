

using GBooks.Domain.Enums;

namespace GBooks.Domain.Commons
{
    public class Language : BaseEntity
    {
        public string Name { get; set; }
        public string LanguageCode { get; set; }
    }
}
