using SQLite;
using System.ComponentModel.DataAnnotations;

namespace Contacts.CoreBusiness
{
    // All the code in this file is included in all platforms.
    public class Contact
    {
        [Required]
        [PrimaryKey, AutoIncrement]
        public int ContactId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Department { get; set; }
        public string AddressStreet { get; set; }
        public string AddressCity { get; set; }
        public string AddressState { get; set; }
        public string AddressZip { get; set; }
        public string AddressCountry { get; set; }
    }
}