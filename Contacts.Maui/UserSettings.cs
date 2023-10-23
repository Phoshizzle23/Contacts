using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Contacts.Maui
{
    public partial class UserSettingsPage
    {
        public class UserSet
        {
            [PrimaryKey, AutoIncrement]
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public bool lightOrDark { get; set; }
        }
    }
}
