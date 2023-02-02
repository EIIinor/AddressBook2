using System;
using System.IO;


namespace WPF_AddressBook2.Services
{
    public class FileService
    {
        private string _filePath;
        
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

    }
}
