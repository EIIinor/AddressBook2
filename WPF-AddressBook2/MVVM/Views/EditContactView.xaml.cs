using System.Windows;
using System.Windows.Controls;
using WPF_AddressBook2.MVVM.Models;
using WPF_AddressBook2.MVVM.ViewModels;

namespace WPF_AddressBook2.MVVM.Views
{
    public partial class EditContactView : UserControl
    {
        public EditContactView()
        {
            InitializeComponent();
        }


        private void ListView_Selected(object sender, RoutedEventArgs e)
        {
            var listViewItem = (ListViewItem)sender;
            var contact = (ContactModel)listViewItem.DataContext;
        }

        private void btn_Update_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_Cancel_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            MainViewModel mainViewModel = (MainViewModel)mainWindow.DataContext;
            mainViewModel.CurrentViewModel = new ContactsViewModel();
        }
    }
}
