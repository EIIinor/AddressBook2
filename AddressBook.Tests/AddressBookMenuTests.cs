using AddressBook.Models;
using AddressBook.Services;

namespace AddressBook.Tests
{
    [TestClass]

    public class AddressBookMenuTests
    {
        [TestMethod]
        public void Should_Add_OneContact_To_List()
        {
            // arrange
            Menu menu = new Menu();
            Contact contact = new Contact();

            // act
            menu.contacts.Add(contact);

            // assert
            Assert.AreEqual(1, menu.contacts.Count);
        }


        [TestMethod]
        public void Should_Remove_OneContact_To_List()
        {
            // arrange
            Menu menu = new Menu();
            Contact contact = new Contact();
            menu.contacts.Add(contact);

            // act
            menu.contacts.Remove(contact);

            // assert
            Assert.AreEqual(0, menu.contacts.Count);
        }

    }
}
