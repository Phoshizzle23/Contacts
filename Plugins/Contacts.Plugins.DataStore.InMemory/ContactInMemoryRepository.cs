using Contacts.UseCases.PluginInterfaces;
using Contact = Contacts.CoreBusiness.Contact;

namespace Contacts.Plugins.DataStore.InMemory
{
    // All the code in this file is included in all platforms.
    public class ContactInMemoryRepository : IContactRepository
    {
        public static List<Contact> _contacts;

        public ContactInMemoryRepository() 
        {
            _contacts = new List<Contact>()
            {
                new Contact {ContactId = 1, Name="John Smith", Email="John_Smith@gmail.com"},
                new Contact {ContactId = 2, Name="Sue White", Email="Sue_White@gmail.com"},
                new Contact {ContactId = 3, Name="Bob O'Bits", Email="Bob_Bits@gmail.com"},
                new Contact {ContactId = 4, Name="Mary Blue", Email="Mary_Blue@gmail.com"},
            };
        }

        public Task AddContactAsync(Contact contact)
        {
            //throw new NotImplementedException();
            var MaxId = _contacts.Max(x => x.ContactId);
            contact.ContactId = MaxId + 1;
            _contacts.Add(contact);

            return Task.CompletedTask;
        }

        public Task DeleteContactAsync(int contactId)
        {
            //throw new NotImplementedException();
            var contact = _contacts.FirstOrDefault(x => x.ContactId == contactId);
            if (contact != null)
            {
                _contacts.Remove(contact);
            }
            return Task.CompletedTask;
        }

        public  Task<List<Contact>> GetContactsAsync(string filterText)
        {
            if(string.IsNullOrWhiteSpace(filterText))
            {
                return Task.FromResult(_contacts);
            }

            var contacts = _contacts.Where(x => !string.IsNullOrWhiteSpace(x.Name) && x.Name.StartsWith(filterText, StringComparison.OrdinalIgnoreCase))?.ToList();

            if (contacts == null || contacts.Count <= 0)
                contacts = _contacts.Where(x => !string.IsNullOrWhiteSpace(x.Email) && x.Email.StartsWith(filterText, StringComparison.OrdinalIgnoreCase))?.ToList();
            else
                return Task.FromResult(contacts);

            if (contacts == null || contacts.Count <= 0)
                contacts = _contacts.Where(x => !string.IsNullOrWhiteSpace(x.Phone) && x.Phone.StartsWith(filterText, StringComparison.OrdinalIgnoreCase))?.ToList();
            else
                return Task.FromResult(contacts);

            if (contacts == null || contacts.Count <= 0)
                contacts = _contacts.Where(x => !string.IsNullOrWhiteSpace(x.AddressStreet) && x.AddressStreet.StartsWith(filterText, StringComparison.OrdinalIgnoreCase))?.ToList();
            else
                return Task.FromResult(contacts);

            return Task.FromResult(contacts);
        }

        public Task<Contact> GetContactsIdAsync(int contactId)
        {
            //throw new NotImplementedException();
            var contact = _contacts.FirstOrDefault(x => x.ContactId == contactId);
            if (contact != null)
            {
                return Task.FromResult(new Contact
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
                });
            }
            return null;
        }

        public Task UpdateContactAsync(int contactId, Contact contact)
        {
            //throw new NotImplementedException();
            if (contactId != contact.ContactId) return Task.CompletedTask;

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
            return Task.CompletedTask;
        }
    }
}