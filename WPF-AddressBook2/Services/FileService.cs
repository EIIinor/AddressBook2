using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_AddressBook2.MVVM.Models;

namespace WPF_AddressBook2.Services
{
    public class FileService
    {
        private string _filePath;

        //public static string FilePath { get; set; } = null!;
        
        public FileService(string filePath)
        {
            _filePath = filePath;
        }

        public string Read()
        {
            try
            {
                using var sr = new StreamReader(_filePath);
                return sr.ReadToEnd();
            }
            catch { return string.Empty; }
        }

        public void Save(string content)
        {
            using var sw = new StreamWriter(_filePath);
            sw.WriteLine(content);
        }


        //public string FilePath { get; set; } = null!;

        //public void Save(string content)
        //{
        //    using var sw = new StreamWriter(FilePath);
        //    sw.WriteLine(content);
        //}

        //public string Read()
        //{
        //    try
        //    {
        //        using var sr = new StreamReader(FilePath);
        //        return sr.ReadToEnd();
        //    }
        //    catch { return null!; }
        //}




        //private string filePath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\WPFContacts.json";
        //private List<Contact> contacts;


        //public FileService()
        //{
        //   ReadFromFile();
        //}

        //private void ReadFromFile()
        //{
        //    try
        //    {
        //        using var sr = new StreamReader(filePath);
        //        contacts = JsonConvert.DeserializeObject<List<Contact>>(sr.ReadToEnd())!;
        //    }
        //    catch { contacts = new List<Contact>(); }
        //}


        //private void SaveToFile()
        //{
        //    using var sw = new StreamWriter(filePath);
        //    sw.WriteLine(JsonConvert.SerializeObject(contacts));
        //}

        //public void AddToList(Contact contact)
        //{
        //    contacts.Add(contact);
        //    SaveToFile();
        //}

        //public ObservableCollection<Contact> Contacts()
        //{
        //    var items = new ObservableCollection<Contact>();
        //    foreach (var contact in contacts)
        //        items.Add(contact);

        //    return items;
        //}
    }
}
