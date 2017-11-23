using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlosbeApi.Net.Model.Translate
{
    public class TranslationResponseModel
    {
        public IEnumerable<Author> Authors { get; set; }
        public string Dest { get; set; }
        public string From { get; set; }
        public string Phrase { get; set; }
        public string Result { get; set; }
        public IEnumerable<Tuc> Tuc { get; set; }
    }
}
