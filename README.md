# Contacts
Repository for the HR Contacts Application V1.0
----------------------------------------------------------------------------------------------------------------------------------------
___________
Mobile Application Screenshots
___________
1.1_Load App

![1.1_Load App.JPG](https://github.com/Phoshizzle23/Contacts/blob/master/Screenshots/1.1_Load%20App.JPG?raw=true)

1.2_Swipe left view

![1.2_Swipe left view.JPG](https://github.com/Phoshizzle23/Contacts/blob/master/Screenshots/1.2_Swipe%20left%20view.JPG?raw=true)

2.1_View Contact

![2.1_View Contact.JPG](https://github.com/Phoshizzle23/Contacts/blob/master/Screenshots/2.1_View%20Contact.JPG?raw=true)

2.2_Add Contact

![2.2_Add Contact.JPG](https://github.com/Phoshizzle23/Contacts/blob/master/Screenshots/2.2_Add%20Contact.JPG?raw=true)

2.3_Edit Contact

![2.3_Edit Contact.JPG](https://github.com/Phoshizzle23/Contacts/blob/master/Screenshots/2.3_Edit%20Contact.JPG?raw=true)

3.1_Enter application settings

![3.1_Enter application settings.JPG](https://github.com/Phoshizzle23/Contacts/blob/master/Screenshots/3.1_Enter%20application%20settings.JPG?raw=true)

3.2_Toggle dark mode

![3.2_Toggle dark mode.JPG](https://github.com/Phoshizzle23/Contacts/blob/master/Screenshots/3.2_Toggle%20dark%20mode.JPG?raw=true)

3.3_Switch to light mode

![3.3_Switch to light mode.JPG](https://github.com/Phoshizzle23/Contacts/blob/master/Screenshots/3.3_Switch%20to%20light%20mode.JPG?raw=true)

4.1_Validate name entry

![4.1_Validate name entry.JPG](https://github.com/Phoshizzle23/Contacts/blob/master/Screenshots/4.1_Validate%20name%20entry.JPG?raw=true)

5.1_Use search function

![5.1_Use search function.JPG](https://github.com/Phoshizzle23/Contacts/blob/master/Screenshots/5.1_Use%20search%20function.JPG?raw=true)
___________
Change Log
___________

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

4. Added screenshots for the mobile version of the application - 16/11/23

4. Deleted all project references to TestPage1

----------------------------------------------------------------------------------------------------------------------------------------
