using System.Globalization;

namespace GlosbeApi.Net.Model
{
    public class DefinitionRequestModel
    {
        public CultureInfo Language { get; set; }
        public string Phrase { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
    }
}
