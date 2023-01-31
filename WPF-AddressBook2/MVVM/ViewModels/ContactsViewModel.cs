using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using WPF_AddressBook2.MVVM.Models;
using WPF_AddressBook2.Services;


namespace WPF_AddressBook2.MVVM.ViewModels
{
    public partial class ContactsViewModel : ObservableObject
    {


        public ContactsViewModel()
        {
            contacts = ContactService.Contacts;

        }



        [ObservableProperty]
        private string pageTitle = "Contacts";


        [ObservableProperty]
        private ObservableCollection<ContactModel> contacts = new ObservableCollection<ContactModel>();


        [ObservableProperty]
        private ContactModel selectedContact = null!;


    }
}
