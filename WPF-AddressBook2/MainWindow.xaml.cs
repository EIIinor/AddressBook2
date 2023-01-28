using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPF_AddressBook2.MVVM.Models;
using WPF_AddressBook2.Services;
using WPF_AddressBook2.CustomControls;
using System.IO;

namespace WPF_AddressBook2
{

    public partial class MainWindow : Window
    {
        //private ObservableCollection<ContactModel> contacts = new ObservableCollection<ContactModel>();
        //private readonly FileService file = new();

        public MainWindow()
        {
            InitializeComponent();
            //file.FilePath = @$"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\ContactsList.json";

            //PopulateContactsList();
        }


        //private void PopulateContactsList()
        //{
        //    try
        //    {
        //        var items = JsonConvert.DeserializeObject<ObservableCollection<ContactModel>>(file.Read());
        //        if (items != null)
        //            contacts = items;
        //    }
        //    catch { }

        //    lv_Contacts.ItemsSource = contacts;
        //}

        //private void lbox_NavMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    var selected = lbox_NavMenu.SelectedItem as NavButtonControl;
        //    frame_PageFrame.Navigate(selected?.NavLink);
        //}

    }
}
