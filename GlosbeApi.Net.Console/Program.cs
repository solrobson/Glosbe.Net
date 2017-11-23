using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GlosbeApi.Net;
using GlosbeApi.Net.Model.Translate;
namespace GlosbeApi.Net.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //Translator t = new Translator();
            //var response = t.GetTranslationAsync(new TranslateRequestModel { Dest = new System.Globalization.CultureInfo("en"), From = new System.Globalization.CultureInfo("en"), Phrase = "words" });
            Definer d = new Definer();
            var response = d.GetDefinitionAsync(new Model.DefinitionRequestModel { Language = new System.Globalization.CultureInfo("en"), Phrase = "words" });
            foreach (var tuc in response.Result.Tuc)
            {
                System.Console.WriteLine("Phrase: " + tuc.Phrase.Text);
                foreach (var meaning in tuc.Meanings)
                {
                    System.Console.WriteLine("{0} {1}", meaning.Language, meaning.Text);
                }
            }
            System.Console.ReadKey();
        }
    }
}
