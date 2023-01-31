using System;


namespace WPF_AddressBook2.MVVM.Models
{
    public class ContactModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string StreetName { get; set; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;

        public string DisplayName => $"{FirstName} {LastName}";

        public string Address => $"{StreetName} {City} {PostalCode}";

    }
}
