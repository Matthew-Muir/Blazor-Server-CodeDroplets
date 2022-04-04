namespace BlazorServerAppDemo.Pages
{
    public partial class Index
    {


        [Inject]
        NavigationManager navigationManager { get; set; }

        [Inject]
        IContactService ContactService { get; set; }

        private List<Contact> contacts;
        private ContactList contactList;
        private bool isContactDisplayed = true;

        private void NavigateToTest()
        {
            navigationManager.NavigateTo("./test");
        }



        protected async override Task OnInitializedAsync()
        {
            await Task.Delay(2000);
            contacts = ContactService.GetContacts();
        
            base.OnInitializedAsync();
        }

        private Dictionary<string, object> myAts = new Dictionary<string, object>
    {
        {"placeholder","bob marley"}
    };

        private void DeleteContact(Contact contact)
        {
            contacts.Remove(contact);
        }

        private void HideContacts()
        {
            isContactDisplayed = !isContactDisplayed;
            if (isContactDisplayed)
            {
                contactList.Hidecontacts();
            }
            else
            {
                contactList.ShowContacts();
            }
        }
    }
}
