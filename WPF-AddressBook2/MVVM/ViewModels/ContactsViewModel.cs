using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_AddressBook2.MVVM.Models;
using WPF_AddressBook2.Services;

namespace WPF_AddressBook2.MVVM.ViewModels
{
    public partial class ContactsViewModel : ObservableObject
    {
        public ContactsViewModel()
        {
            contacts = ContactService.Contacts;
        }

        [ObservableProperty]
        private string pageTitle = "Contacts";

        [ObservableProperty]
        private ObservableCollection<ContactModel> contacts;

        [ObservableProperty]
        private ContactModel selectedContact = null!;

        //    private readonly ContactService contactService;

        //    public ContactsViewModel()
        //    {
        //        contactService = new ContactService();
        //        contacts = contactService.Contacts();
        //    }

        //    [ObservableProperty]
        //    private string pageTitle = "Contacts";

        //    [ObservableProperty]
        //    private ObservableCollection<ContactModel> contacts;
        }
    }
