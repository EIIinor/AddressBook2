using Newtonsoft.Json;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using WPF_AddressBook2.MVVM.Models;
using WPF_AddressBook2.MVVM.ViewModels;

namespace WPF_AddressBook2.Services
{
    public class ContactService
    {

        public static ObservableCollection<ContactModel> Contacts;
        public static FileService fileService = new FileService($@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\WPF.contacts.json");


        static ContactService()
        {
            try
            {
                Contacts = JsonConvert.DeserializeObject<ObservableCollection<ContactModel>>(fileService.Read())!;
            }
            catch { Contacts = new ObservableCollection<ContactModel>(); }

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


        public static void UpdateContact(ContactModel model)
        {
            var contact = Contacts.FirstOrDefault(x => x.Id == model.Id);
            if (contact != null)
            {
                contact.FirstName = model.FirstName;
                contact.LastName = model.LastName;
                contact.Phone = model.Phone;
                contact.Email = model.Email;
                contact.StreetName = model.StreetName;
                contact.City = model.City;
                contact.PostalCode = model.PostalCode;
            }
            fileService.Save(JsonConvert.SerializeObject(Contacts));
        }

    }
}

//Contacts = new ObservableCollection<ContactModel>();
//FileService.FilePath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\WPF.contacts.json";

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