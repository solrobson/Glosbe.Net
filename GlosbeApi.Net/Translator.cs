using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GlosbeApi.Net.Model.Translate;
using System.Net.Http;
using System.Net.Http.Headers;

namespace GlosbeApi.Net
{
    public class Translator
    {
        private string _translateEndPoint = "https://glosbe.com/gapi_v0_1/translate";
        private string _queryString = "?from={0}&dest={1}&format=json&phrase={2}";

        public async Task<TranslateResponseModel> GetTranslationAsync(TranslateRequestModel request)
        {
            var traslationResponse = new TranslateResponseModel();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_translateEndPoint);
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));

                var queryString = String.Format(_queryString, request.From.ThreeLetterISOLanguageName, request.Dest.ThreeLetterISOLanguageName, request.Phrase);
                
                var response = await client.GetAsync(queryString);
               
                if (response.IsSuccessStatusCode)
                {
                    traslationResponse = response.Content.ReadAsAsync<TranslateResponseModel>().Result;
                }
            }

            return traslationResponse;
        }
    }
}
