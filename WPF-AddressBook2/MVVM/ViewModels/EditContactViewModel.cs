using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WPF_AddressBook2.MVVM.Models;

using System.Windows.Input;

namespace WPF_AddressBook2.MVVM.ViewModels
{
    public partial class EditContactViewModel: ObservableObject
    {

        [ObservableProperty]
        private string pageTitle = "Update Contact";


        [ObservableProperty]
        private string contact = string.Empty;


        [ObservableProperty]
        private ContactModel selectedContact = null!;



        [RelayCommand]
        private void UpdateContact()
        {
            //var selectedContact = ContactService.Contacts.FirstOrDefault(c => c.Id == this.SelectedContact.Id);

            //if (selectedContact == null) return;

            //selectedContact.FirstName = this.FirstName;
            //selectedContact.LastName = this.LastName;
            //selectedContact.Email = this.Email;
            //selectedContact.Phone = this.Phone;
            //selectedContact.StreetName = this.StreetName;
            //selectedContact.PostalCode = this.PostalCode;
            //selectedContact.City = this.City;

            //ContactService.fileService.Save(JsonConvert.SerializeObject(ContactService.Contacts));
        }
    }
}
