using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlosbeApi.Net.Model.Translate
{
    public class Tuc
    {
        public IEnumerable<int> Author { get; set; }
        public long MeaningId { get; set; }
        public IEnumerable<Phrase> Meanings { get; set; }
        public Phrase Phrase { get; set; }
    }
}
