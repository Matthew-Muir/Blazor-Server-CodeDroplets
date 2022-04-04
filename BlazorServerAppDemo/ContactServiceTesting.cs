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
                },

                new Contact()
                {
                    FirstName = "Lola",
                    LastName = "Bola",
                    Email = "yum@yahoo.com"
                },

                new Contact(){
                    FirstName = "Titus",
                    LastName = "BowBitus",
                    Email = "badDoggy@gmail.com"
                }
            };
        }
    }
}
