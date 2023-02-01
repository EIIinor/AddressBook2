using CommunityToolkit.Mvvm.ComponentModel;
using WPF_AddressBook2.MVVM.Models;
using System.Windows;


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

        public EditContactViewModel()
        {   

            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            MainViewModel mainViewModel = (MainViewModel)mainWindow.DataContext;
            SelectedContact = mainViewModel.SelectedContact ?? new ContactModel();

        }


        //[RelayCommand]
        //private void UpdateContact()
        //{
        //    ContactService.UpdateContact(SelectedContact);

        //    //if (SelectedContact != null)
        //    //{
        //    //    SelectedContact.FirstName = model.FirstName;
        //    //    SelectedContact.LastName = model.LastName;
        //    //    SelectedContact.Phone = model.Phone;
        //    //    SelectedContact.Email = model.Email;
        //    //    SelectedContact.StreetName = model.StreetName;
        //    //    SelectedContact.City = model.City;
        //    //    SelectedContact.PostalCode = model.PostalCode;
        //    //    ContactService.UpdateContact(SelectedContact);
        //    //}

        //    //MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
        //    //MainViewModel mainViewModel = (MainViewModel)mainWindow.DataContext;
        //    //mainViewModel.CurrentViewModel = new ContactsViewModel();
        //}
    }
}
