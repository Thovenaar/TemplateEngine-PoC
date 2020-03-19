namespace TemplatePoc.Models
{
    public class Header : IMailComponent
    {
        public Header(string title)
        {
            Title = title;
        }
        public string Title { get; set; }
    }
}