using WPF_AddressBook2.MVVM.Models;
using WPF_AddressBook2.Services;

namespace WPF_AddressBook.Tests
{
    public class ContactService_Tests
    {
        private ContactService contactService;
        ContactModel contactModel;


        public ContactService_Tests() 
        {
            // arrange
            contactService = new ContactService();
            contactModel = new ContactModel();
            ContactService.Contacts.Clear();
        }


        [Fact]
        public void Should_Add_Contact_To_List()
        {
            ContactService.AddToList(contactModel);
            ContactService.AddToList(contactModel);

            // assert
            Assert.Equal(2, ContactService.Contacts.Count);
        }

        [Fact]
        public void Should_Remove_Contact_From_List()
        {
            // arrange
            ContactService.AddToList(contactModel);
            ContactService.AddToList(contactModel);

            // act
            ContactService.RemoveFromList(contactModel);

            // assert
            Assert.Single(ContactService.Contacts);
        }
    }
}