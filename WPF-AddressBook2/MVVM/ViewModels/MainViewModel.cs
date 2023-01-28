﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_AddressBook2.MVVM.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableObject currentViewModel;


        [RelayCommand]
        private void GoToAddContact() => CurrentViewModel = new AddContactViewModel();


     


        [RelayCommand]
        private void GoToContacts()
        {
            CurrentViewModel = new ContactsViewModel();
        }

  

        public MainViewModel() 
        {
            CurrentViewModel= new ContactsViewModel();
        }
    }
}
