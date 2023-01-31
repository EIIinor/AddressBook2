using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WPF_AddressBook2.Services;
using WPF_AddressBook2.MVVM.Models;

namespace WPF_AddressBook2.MVVM.ViewModels
{
    public partial class AddContactViewModel : ObservableObject
    {

        [ObservableProperty]
        private string pageTitle = "Add Contact";

        [ObservableProperty]
        private ContactModel contact = new ContactModel();

        //[ObservableProperty]
        //private string contact = string.Empty;

        [RelayCommand]
        private void Add(ContactModel contact)
        {
            ContactService.AddToList(contact);
            //ClearForm(contact);
        }

        //private void ClearForm(ContactModel contact)
        //{
        //    Contact.FirstName = string.Empty;
        //    contact.LastName = string.Empty;
        //    contact.Phone = string.Empty;
        //    contact.Email = string.Empty;
        //    contact.StreetName = string.Empty
        //    contact.City = string.Empty;
        //    contact.PostalCode = "";
        //}
    }
}
