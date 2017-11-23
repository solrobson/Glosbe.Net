using System.Globalization;

namespace GlosbeApi.Net.Model.Translate
{
    public class TranslateRequestModel
    {
        public CultureInfo From { get; set; }
        public CultureInfo Dest { get; set; }
        public string Phrase { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
    }
}
