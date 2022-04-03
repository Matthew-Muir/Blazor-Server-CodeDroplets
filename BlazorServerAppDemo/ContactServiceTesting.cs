namespace BlazorServerAppDemo
{
    public class ContactServiceTesting : IContactService
    {
        public void AddContact(Contact contact)
        {
            
        }

        public List<Contact> GetContacts()
        {
            return new List<Contact>()
            {
                new Contact()
                {
                    FirstName = "Kevin",
                    LastName = "Menice",
                    Email = "hott@aol.com"
                }
            };
        }
    }
}
