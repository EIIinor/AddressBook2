using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using WPF_AddressBook2.Models;
using WPF_AddressBook2.Services;
using WPF_AddressBook2.MVVM.Models;

namespace WPF_AddressBook2.MVVM.ViewModels
{
    public partial class AddContactViewModel : ObservableObject
    {

        [ObservableProperty]
        private string pageTitle = "Add Contact";

        [ObservableProperty]
        private string contact = string.Empty;

        [RelayCommand]
        private void Add()
        {
            var contact = new ContactModel
            {
                FirstName = "",
                LastName = "",
                Phone = "",
                Email = "",
                StreetName = "",
                PostalCode = "",
                City = "",
            };

            ContactService.AddToList(contact);
        }


    }
}
