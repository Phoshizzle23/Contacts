using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Windows.ApplicationModel.Search;

namespace Contacts.Maui.Models
{
    public static class ContactRepository
    {
        public static List<Contact> _contacts = new List<Contact>()
        {
            new Contact {ContactId = 1, Name="John Smith", Email="John_Smith@gmail.com"},
            new Contact {ContactId = 2, Name="Sue White", Email="Sue_White@gmail.com"},
            new Contact {ContactId = 3, Name="Bob O'Bits", Email="Bob_Bits@gmail.com"},
            new Contact {ContactId = 4, Name="Mary Blue", Email="Mary_Blue@gmail.com"},
        };

        public static List<Contact> GetContacts() => _contacts;

        public static Contact GetContactById(int contactId)
        {
            var contact =  _contacts.FirstOrDefault(x => x.ContactId == contactId);
            if (contact !=null)
            {
                return new Contact 
                { 
                    ContactId = contactId,
                    AddressStreet = contact.AddressStreet,
                    AddressCity = contact.AddressCity,
                    AddressState = contact.AddressState,
                    AddressZip = contact.AddressZip,
                    AddressCountry = contact.AddressCountry,
                    Email = contact.Email,
                    Name = contact.Name,
                    Phone = contact.Phone,
                    Department = contact.Department,
                };
            }
            return null;
        }

        public static void UpdateContact(int contactId, Contact contact) 
        {
            if (contactId != contact.ContactId) return;

            var contactToUpdate = _contacts.FirstOrDefault(x => x.ContactId == contactId);
            if (contactToUpdate != null)
            {
                // Check AutoMapper
                contactToUpdate.AddressStreet = contact.AddressStreet;
                contactToUpdate.AddressCity = contact.AddressCity;
                contactToUpdate.AddressState = contact.AddressState;
                contactToUpdate.AddressZip = contact.AddressZip;
                contactToUpdate.AddressCountry = contact.AddressCountry;
                contactToUpdate.Department = contact.Department;
                contactToUpdate.Email = contact.Email;
                contactToUpdate.Phone = contact.Phone;
                contactToUpdate.Name = contact.Name;
            }               
        }

        public static void AddContact(Contact contact)
        {
            var MaxId = _contacts.Max(x => x.ContactId);
            contact.ContactId = MaxId + 1;
            _contacts.Add(contact);
        }

        public static void DeleteContact(int contactId)
        {
            var contact = _contacts.FirstOrDefault(x => x.ContactId == contactId);
            if (contact != null)
            {
                _contacts.Remove(contact);
            }
        }

        public static List<Contact> SearchContacts(string filterText)
        {
            var contacts = _contacts.Where(x => !string.IsNullOrWhiteSpace(x.Name) && x.Name.StartsWith(filterText, StringComparison.OrdinalIgnoreCase))?.ToList();

            if (contacts == null || contacts.Count <=0)
                contacts = _contacts.Where(x => !string.IsNullOrWhiteSpace(x.Email) && x.Email.StartsWith(filterText, StringComparison.OrdinalIgnoreCase))?.ToList();
            else
                return contacts;

            if (contacts == null || contacts.Count <= 0)
                contacts = _contacts.Where(x => !string.IsNullOrWhiteSpace(x.Phone) && x.Phone.StartsWith(filterText, StringComparison.OrdinalIgnoreCase))?.ToList();
            else
                return contacts;

            if (contacts == null || contacts.Count <= 0)
                contacts = _contacts.Where(x => !string.IsNullOrWhiteSpace(x.AddressStreet) && x.AddressStreet.StartsWith(filterText, StringComparison.OrdinalIgnoreCase))?.ToList();
            else
                return contacts;

            return contacts;
        }
    }
}
