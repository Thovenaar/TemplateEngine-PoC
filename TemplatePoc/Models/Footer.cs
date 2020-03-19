namespace TemplatePoc.Models
{
    public class Footer : IMailComponent
    {
        public Footer(string companyName)
        {
            CompanyName = companyName;
        }
        public string CompanyName { get; set; }
    }
}