using System.Collections.Generic;

namespace TemplatePoc.Models
{
    public class ParticipantList : IMailComponent
    {
        public List<Contact> Contacts { get; set; }

        public class Contact
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
    }
}