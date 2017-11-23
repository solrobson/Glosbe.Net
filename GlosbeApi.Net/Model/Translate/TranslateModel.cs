namespace GlosbeApi.Net.Model.Translate
{
    public class TranslateRequestModel
    {
        public string From { get; set; }
        public string Dest { get; set; }
        public string Phrase { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
    }
}
