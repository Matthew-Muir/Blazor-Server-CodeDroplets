namespace BlazorServerAppDemo.Pages
{
    public partial class Index
    {
        [Inject]
        IContactService ContactService { get; set; }
        protected async override Task OnInitializedAsync()
        {
            await Task.Delay(2000);
            contacts = ContactService.GetContacts();
        //    contacts = new List<Contact>
        //{
        //    new Contact
        //    {
        //        FirstName = "Lola",
        //        LastName = "Bola",
        //        Email = "hungrypup@gmail.com"
        //    },

        //    new Contact
        //    {
        //        FirstName = "Professor",
        //        LastName = "Kitty",
        //        Email = "meow!@yahoo.com"
        //    },

        //    new Contact
        //    {
        //        FirstName = "Titus",
        //        LastName = "Bobitus",
        //        Email = "kenneldaddy@hotmail.com"
        //    }
        //};
            base.OnInitializedAsync();
        }

        private Dictionary<string, object> myAts = new Dictionary<string, object>
    {
        {"placeholder","bob marley"}
    };
        private List<Contact> contacts;

        private void DeleteContact(Contact contact)
        {
            contacts.Remove(contact);
        }
    }
}
