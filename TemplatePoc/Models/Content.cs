namespace TemplatePoc.Models
{
    public class Content : IMailComponent
    {
        public Content(string value)
        {
            Value = value;
        }
        public string Value { get; set; }
    }
}
