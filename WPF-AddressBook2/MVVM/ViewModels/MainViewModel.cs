using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WPF_AddressBook2.MVVM.Models;


namespace WPF_AddressBook2.MVVM.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {

        [ObservableProperty]
        private ContactModel selectedContact;


        [ObservableProperty]
        private ObservableObject currentViewModel;


        [RelayCommand]
        private void GoToAddContact() => CurrentViewModel = new AddContactViewModel();


        [RelayCommand]
        public void GoToEditContact() => CurrentViewModel = new EditContactViewModel();



        [RelayCommand]
        private void GoToContacts()
        {
            CurrentViewModel = new ContactsViewModel();
        }


        public MainViewModel() 
        {
            CurrentViewModel= new ContactsViewModel();
        }

    }
}
