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


        [RelayCommand]
        private void Add()
        {
            ContactService.AddToList(Contact);

            Contact = new ContactModel();
        }


    }
}
