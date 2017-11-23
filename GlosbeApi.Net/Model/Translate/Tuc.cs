using System;
using System.Collections.Generic;

namespace GlosbeApi.Net.Model.Translate
{
    public class Tuc
    {
        public Tuc()
        {
            Phrase = new Phrase();
            Meanings = new List<Phrase>();
        }

        public IEnumerable<int> Authors { get; set; }
        public Int64? MeaningId { get; set; }
        public IEnumerable<Phrase> Meanings { get; set; }
        public Phrase Phrase { get; set; }
    }
}
