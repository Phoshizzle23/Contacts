using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Contact = Contacts.CoreBusiness.Contact;

namespace Contacts.UseCases.PluginInterfaces
{
    public interface IContactRepository
    {
        Task AddContactAsync(Contact contact);
        Task DeleteContactAsync(int contactId);
        Task<List<Contact>> GetContactsAsync(string filterText);
        Task<Contact> GetContactsIdAsync(int contactId);
        Task UpdateContactAsync(int contactId, Contact contact);
    }
}
