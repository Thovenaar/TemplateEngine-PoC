using System.Collections.Generic;
using TemplatePoc.Models;

namespace TemplatePoc.Factories
{
    public class MailComponentFactory
    {
        public IMailComponent Create(string component)
        {
            return component.ToLower() switch
            {
                "header" => new Header("De factuur voor uw reis naar Japan"),
                "participantlist" => new ParticipantList
                {
                    Contacts = new List<ParticipantList.Contact>
                    {
                        new ParticipantList.Contact
                        {
                            FirstName = "Foo",
                            LastName = "Bar"
                        },
                        new ParticipantList.Contact
                        {
                            FirstName = "John",
                            LastName = "Skeet"
                        }
                    }
                },
                "footer" => new Footer("Groeten van ANWB Reizen"),
                _ => new Content("")
            };
        }
    }
}
