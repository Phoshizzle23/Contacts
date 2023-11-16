# Contacts
Repository for the HR Contacts Application V1.0
----------------------------------------------------------------------------------------------------------------------------------------
___________
Mobile Application Screenshots
___________
<p align="center">1.1_Load App</p>

<p align="center">
  <img src="https://github.com/Phoshizzle23/Contacts/blob/master/Screenshots/1.1_Load%20App.JPG?raw=true" alt="1.1_Load App.JPG">
</p>

<p align="center">1.2_Swipe left view</p>

<p align="center">
  <img src="https://github.com/Phoshizzle23/Contacts/blob/master/Screenshots/1.2_Swipe%20left%20view.JPG?raw=true" alt="1.2_Swipe left view.JPG">
</p>

<p align="center">2.1_View Contact</p>

<p align="center">
  <img src="https://github.com/Phoshizzle23/Contacts/blob/master/Screenshots/2.1_View%20Contact.JPG?raw=true" alt="2.1_View Contact.JPG">
</p>

<p align="center">2.2_Add Contact</p>

<p align="center">
  <img src="https://github.com/Phoshizzle23/Contacts/blob/master/Screenshots/2.2_Add%20Contact.JPG?raw=true" alt="2.2_Add Contact.JPG">
</p>

<p align="center">2.3_Edit Contact</p>

<p align="center">
  <img src="https://github.com/Phoshizzle23/Contacts/blob/master/Screenshots/2.3_Edit%20Contact.JPG?raw=true" alt="2.3_Edit Contact.JPG">
</p>

<p align="center">3.1_Enter application settings</p>

<p align="center">
  <img src="https://github.com/Phoshizzle23/Contacts/blob/master/Screenshots/3.1_Enter%20application%20settings.JPG?raw=true" alt="3.1_Enter application settings.JPG">
</p>

<p align="center">3.2_Toggle dark mode</p>

<p align="center">
  <img src="https://github.com/Phoshizzle23/Contacts/blob/master/Screenshots/3.2_Toggle%20dark%20mode.JPG?raw=true" alt="3.2_Toggle dark mode.JPG">
</p>

<p align="center">3.3_Switch to light mode</p>

<p align="center">
  <img src="https://github.com/Phoshizzle23/Contacts/blob/master/Screenshots/3.3_Switch%20to%20light%20mode.JPG?raw=true" alt="3.3_Switch to light mode.JPG">
</p>

<p align="center">4.1_Validate name entry</p>

<p align="center">
  <img src="https://github.com/Phoshizzle23/Contacts/blob/master/Screenshots/4.1_Validate%20name%20entry.JPG?raw=true" alt="4.1_Validate name entry.JPG">
</p>

<p align="center">5.1_Use search function</p>

<p align="center">
  <img src="https://github.com/Phoshizzle23/Contacts/blob/master/Screenshots/5.1_Use%20search%20function.JPG?raw=true" alt="5.1_Use search function.JPG">
</p>

___________
Tablet Application Screenshots
___________
<p align="center">1.1_Load App</p>

<p align="center">
  <img src="https://github.com/Phoshizzle23/Contacts/blob/master/Screenshots/1.1_Load%20AppTab.jpg?raw=true" alt="1.1_Load App.JPG">
</p>

<p align="center">1.2_Swipe left view</p>

<p align="center">
  <img src="https://github.com/Phoshizzle23/Contacts/blob/master/Screenshots/1.2_SwipeleftviewTab.jpg?raw=true" alt="1.2_Swipe left view.JPG">
</p>

<p align="center">2.1_View Contact</p>

<p align="center">
  <img src="https://github.com/Phoshizzle23/Contacts/blob/master/Screenshots/2.1_ViewContactTab.jpg?raw=true" alt="2.1_View Contact.JPG">
</p>

<p align="center">2.2_Add Contact</p>

<p align="center">
  <img src="https://github.com/Phoshizzle23/Contacts/blob/master/Screenshots/2.2_AddContactTab.jpg?raw=true" alt="2.2_Add Contact.JPG">
</p>

<p align="center">2.3_Edit Contact</p>

<p align="center">
  <img src="https://github.com/Phoshizzle23/Contacts/blob/master/Screenshots/2.3_EditContactTab.jpg?raw=true" alt="2.3_Edit Contact.JPG">
</p>

<p align="center">3.1_Enter application settings</p>

<p align="center">
  <img src="https://github.com/Phoshizzle23/Contacts/blob/master/Screenshots/3.1_EnterApplicationSettingsTab.jpg?raw=true" alt="3.1_Enter application settings.JPG">
</p>

<p align="center">3.2_Toggle dark mode</p>

<p align="center">
  <img src="https://github.com/Phoshizzle23/Contacts/blob/master/Screenshots/3.2_ToggledarkmodeTab.jpg?raw=true" alt="3.2_Toggle dark mode.JPG">
</p>

<p align="center">3.3_Switch to light mode</p>

<p align="center">
  <img src="https://github.com/Phoshizzle23/Contacts/blob/master/Screenshots/3.3_SwitchToLightModeTab.jpg?raw=true" alt="3.3_Switch to light mode.JPG">
</p>

<p align="center">4.1_Validate name entry</p>

<p align="center">
  <img src="https://github.com/Phoshizzle23/Contacts/blob/master/Screenshots/4.1_ValidateNameEntryTab.jpg?raw=true" alt="4.1_Validate name entry.JPG">
</p>

<p align="center">5.1_Use search function</p>

<p align="center">
  <img src="https://github.com/Phoshizzle23/Contacts/blob/master/Screenshots/5.1_UseSearchFunctionTab.jpg?raw=true" alt="5.1_Use search function.JPG">
</p>

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


4. Deleted all project references to TestPage1

5. Added screenshots for the mobile version of the application - 16/11/23

6. Added screenshots for the mobile version of the application - 17/11/23
----------------------------------------------------------------------------------------------------------------------------------------
