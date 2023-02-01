using System.Windows;
using System.Windows.Controls;
using WPF_AddressBook2.MVVM.Models;
using WPF_AddressBook2.MVVM.ViewModels;
using WPF_AddressBook2.Services;

namespace WPF_AddressBook2.MVVM.Views
{
    public partial class ContactsView : UserControl
    {
   
        public ContactsView()
        {
            InitializeComponent();
      
        }

        private void btn_Edit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            MainViewModel mainViewModel = (MainViewModel)mainWindow.DataContext;

            ContactModel selectedContact = (sender as Button).DataContext as ContactModel;

            EditContactViewModel editContactViewModel = new EditContactViewModel();
            editContactViewModel.SelectedContact = selectedContact;

            mainViewModel.CurrentViewModel = editContactViewModel;
        }


        private void btn_Remove_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to delete this contact?", "Confirm Deletion", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                var contact = (sender as Button).DataContext as ContactModel;
                ContactService.RemoveFromList(contact);
            }
        }


        private void ListView_Selected(object sender, RoutedEventArgs e)
        {
            var listViewItem = (ListViewItem)sender;
            var contact = (ContactModel)listViewItem.DataContext;
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            ContactsViewModel contactsViewModel = (ContactsViewModel)mainWindow.DataContext;
            contactsViewModel.SelectedContact = contact;
        }


        //private void ListView_Selected(object sender, RoutedEventArgs e)
        //{
        //    var listViewItem = (ListViewItem)sender;
        //    var contact = (ContactModel)listViewItem.DataContext;
        //}
    }
}
