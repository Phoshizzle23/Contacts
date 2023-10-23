# Contacts
Repository for the HR Contacts Application

Change List

24/10/2023

1. Deleted redundant code from Contacts.Maui.Views.Controls.ContactsPage 

//List<Contact> contacts = ContactRepository.GetContacts();

//listContacts.ItemsSource = contacts;

//List<Contact> contacts = new List<Contact>() //Hard coded list
//{ 
//new Contact {Name="John Doe", Email="John_Doe@gmail.com"},
//new Contact {Name="Jane Doe", Email="Jane_Doe@gmail.com"},
//new Contact {Name="Tom Hanks", Email="Tom_Hanks@gmail.com"},
//new Contact {Name="Frank Liu", Email="Frank_Liu@gmail.com"},
//};

//List<string> contacts = new List<string>() { 
//    "John Doe",
//    "Jane Doe",
//    "Tom Hanks",
//    "Frank Liu"};

//listContacts.ItemsSource = contacts;

2. Deleted unused Testpage1.xaml from Contacts.Maui.Views.Controls

3. Deleted redundant code from Contacts.Maui.Views.Controls.AddContactsPage 

//private void btnCancel_Clicked(object sender, EventArgs e)
//{
//    Shell.Current.GoToAsync(".."); //To go back one page
//    //Shell.Current.GoToAsync("$//{nameof(ContactPage)}"); // Other way to navigate back
//}

//ContactRepository.AddContact(new Models.Contact
//{
//    Name = contactCtrl.Name,
//    Email = contactCtrl.Email,
//    Phone = contactCtrl.Phone,
//    Department = contactCtrl.Department,
//    AddressStreet = contactCtrl.AddressStreet,
//    AddressState = contactCtrl.AddressState,
//    AddressCity = contactCtrl.AddressCity,
//    AddressZip = contactCtrl.AddressZip,
//    AddressCountry = contactCtrl.AddressCountry,
//});

4. Deleted all project references to TestPage1
