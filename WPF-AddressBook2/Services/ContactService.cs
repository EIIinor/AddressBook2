using Newtonsoft.Json;
using System;
using System.Collections.ObjectModel;


using WPF_AddressBook2.MVVM.Models;

namespace WPF_AddressBook2.Services
{
    public static class ContactService
    {

        public static ObservableCollection<ContactModel> Contacts;
        private static FileService fileService = new FileService($@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\WPF.contacts.json");


        static ContactService()
        {
            try
            {
                Contacts = JsonConvert.DeserializeObject<ObservableCollection<ContactModel>>(fileService.Read())!;
            }
            catch { Contacts = new ObservableCollection<ContactModel>(); }
            //Contacts = new ObservableCollection<ContactModel>();
            //FileService.FilePath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\WPF.contacts.json";

        }


        public static void AddToList(ContactModel model)
        {
            Contacts.Add(model);
            fileService.Save(JsonConvert.SerializeObject(Contacts));
        }



        public static void RemoveFromList(ContactModel model)
        {
            Contacts.Remove(model);
            fileService.Save(JsonConvert.SerializeObject(Contacts));
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
