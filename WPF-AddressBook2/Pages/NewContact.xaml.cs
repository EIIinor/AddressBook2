using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPF_AddressBook2.MVVM.Models;
using WPF_AddressBook2.Services;

namespace WPF_AddressBook2.Pages
{

    public partial class NewContact : Page
    {
        //    private readonly FileService fileService;
        //    private List<ContactModel> contacts;

        //    private string FilePath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\WPFContacts.json";

        public NewContact()
        {
            InitializeComponent();
            //fileService = new FileService();
        }

        //    private void btn_Add_Click(object sender, RoutedEventArgs e)
        //    {
        //        //contacts.Add(new Contact
        //        //{
        //        //    FirstName = tb_FirstName.Text,
        //        //    LastName = tb_LastName.Text,
        //        //    Email = tb_Email.Text,
        //        //    Phone = tb_Phone.Text,
        //        //    StreetName = tb_StreetName.Text,
        //        //    City = tb_City.Text,
        //        //    PostalCode = tb_PostalCode.Text,
        //        //});

        //        //file.Save(JsonConvert.SerializeObject(contacts));
        //        //ClearForm();


        //        AddToList(new ContactModel
        //        {
        //            FirstName = tb_FirstName.Text,
        //            LastName = tb_LastName.Text,
        //            Email = tb_Email.Text,
        //            Phone = tb_Phone.Text,
        //            StreetName = tb_StreetName.Text,
        //            City = tb_City.Text,
        //            PostalCode = tb_PostalCode.Text,
        //        });

        //        ClearForm();
        //    }

        //    public void AddToList(ContactModel contact)
        //    {
        //        contacts.Add(contact);
        //        //fileService.Save(JsonConvert.SerializeObject(contacts));
        //        //SaveToFile();
        //    }

        //    //private void SaveToFile()
        //    //{
        //    //    using var sw = new StreamWriter(FilePath);
        //    //    sw.WriteLine(JsonConvert.SerializeObject(contacts));
        //    //}

        //    private void ClearForm()
        //    {
        //        tb_FirstName.Text = "";
        //        tb_LastName.Text = "";
        //        tb_Email.Text = "";
        //        tb_Phone.Text = "";
        //        tb_StreetName.Text = "";
        //        tb_City.Text = "";
        //        tb_PostalCode.Text = "";
        //    }
    }
}
