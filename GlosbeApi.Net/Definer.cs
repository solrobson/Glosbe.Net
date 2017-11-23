using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GlosbeApi.Net.Model;
using GlosbeApi.Net.Model.Translate;

namespace GlosbeApi.Net
{
    public class Definer
    {
        private readonly Translator _translator;

        public Definer() : this(new Translator())
        {

        }

        public Definer(Translator translator)
        {
            _translator = translator ?? throw new ArgumentException(nameof(translator));
        }

        public async Task<TranslateResponseModel> GetDefinitionAsync(DefinitionRequestModel request)
        {
            if(request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }
            
            //Getting a definition is translation a word with the same Dest and From language.
            var translateRequest = new TranslateRequestModel
            {
                Dest = request.Language,
                From = request.Language,
                Page = request.Page,
                PageSize = request.PageSize,
                Phrase = request.Phrase
            };

            var response = await _translator.GetTranslationAsync(translateRequest);
            return response;
        }
    }
}
