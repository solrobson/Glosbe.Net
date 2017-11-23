using System.Collections.Generic;

namespace GlosbeApi.Net.Model.Translate
{
    public class TranslateResponseModel
    {
        public IDictionary<int, Author> Authors { get; set; }
        public string Dest { get; set; }
        public string From { get; set; }
        public string Phrase { get; set; }
        public string Result { get; set; }
        public IEnumerable<Tuc> Tuc { get; set; }
    }
}
