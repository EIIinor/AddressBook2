using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using WPF_AddressBook2.Models;
using WPF_AddressBook2.MVVM.Models;

namespace WPF_AddressBook2.Services
{
    public static class ContactService
    {
        public static ObservableCollection<ContactModel> Contacts = new ObservableCollection<ContactModel>();

        static ContactService()
        {
            //Contacts = new ObservableCollection<ContactModel>();
            FileService.FilePath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\WPF.contacts.json";
        }

        public static void AddToList(ContactModel model)
        {
            Contacts.Add(model);
            FileService.Save(JsonConvert.SerializeObject(Contacts));
        }



        public static void RemoveFromList(ContactModel model)
        {
            Contacts.Remove(model);
            FileService.Save(JsonConvert.SerializeObject(Contacts));
        }




        //   ReadFromFile();
        //}



        //public void AddToList(Contact contact)
        //{
        //    contacts.Add(contact);
        //    SaveToFile();
        //}


        //public void RemoveFromList(Contact contact)
        //{
        //    contacts.Remove(contact);
        //    SaveToFile();
        //}
    }
}
