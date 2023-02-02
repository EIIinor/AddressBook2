using CommunityToolkit.Mvvm.ComponentModel;
using WPF_AddressBook2.MVVM.Models;
using System.Windows;
using CommunityToolkit.Mvvm.Input;
using WPF_AddressBook2.Services;

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

        [RelayCommand]
        private void Update()
        {
            ContactService.UpdateContact();
            MessageBox.Show("Your contact has been updated.");
        }

        //    //MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
        //    //MainViewModel mainViewModel = (MainViewModel)mainWindow.DataContext;
        //    //mainViewModel.CurrentViewModel = new ContactsViewModel();
    }
}
