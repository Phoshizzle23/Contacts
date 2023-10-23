using Contacts.Maui.Models;
using Contacts.UseCases.Interfaces;
using System.Collections.ObjectModel;
using static System.Net.Mime.MediaTypeNames;
using Contact = Contacts.CoreBusiness.Contact;

namespace Contacts.Maui.Views;

public partial class ContactsPage : ContentPage
{
    private readonly IViewContactsUseCase viewContactsUseCase;
    private readonly IDeleteContactUseCase deleteContactUseCase;

    public ContactsPage(IViewContactsUseCase viewContactsUseCase,
        IDeleteContactUseCase deleteContactUseCase)
	{
		InitializeComponent();
        this.viewContactsUseCase = viewContactsUseCase;
        this.deleteContactUseCase = deleteContactUseCase;

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
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        SearchBar.Text = string.Empty;

        LoadContacts();

        //var contacts = new ObservableCollection<Contact>(ContactRepository.GetContacts());
        //listContacts.ItemsSource = contacts;

    }

    // This has been moved to the Models Folder
    //public class Contact
    //{
    //    public string Name { get; set; }
    //    public string Email { get; set; }       

    //}

    private async void listContacts_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {        

        if (listContacts.SelectedItem != null)
        {
            //Logic
            //DisplayAlert("test", "test", "Ok");
            //await Shell.Current.GoToAsync(nameof(EditContactPage));
            await Shell.Current.GoToAsync($"{nameof(EditContactPage)}?Id={((CoreBusiness.Contact)listContacts.SelectedItem).ContactId}");
        }

        //listContacts.SelectedItem = null;
    }

    private void listContacts_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        listContacts.SelectedItem = null;
    }

    private void btdAdd_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(AddContactPage));
    }

    private async void Delete_Clicked(object sender, EventArgs e)
    {
        var menuItem = sender as MenuItem;
        var contact = menuItem.CommandParameter as Contact;
        //ContactRepository.DeleteContact(contact.ContactId);
        await deleteContactUseCase.ExecuteAsync(contact.ContactId);

        LoadContacts();
    }

    private async void LoadContacts()
    {
        var contacts = new ObservableCollection<CoreBusiness.Contact>(await this.viewContactsUseCase.ExcecuteAsync(string.Empty));
        listContacts.ItemsSource = contacts;
    }

    private async void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
    {
        //var contacts = new ObservableCollection<Contact>(ContactRepository.SearchContacts(((SearchBar)sender).Text));
        var contacts = new ObservableCollection<CoreBusiness.Contact>(await this.viewContactsUseCase.ExcecuteAsync(((SearchBar)sender).Text));
        listContacts.ItemsSource = contacts;
    }

    private void btdTest_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(TestPage1));
    }



    //private void btnEditContact_Clicked(object sender, EventArgs e)
    //{
    //    Shell.Current.GoToAsync(nameof(EditContactPage));
    //}

    //private void btnAddContact_Clicked(object sender, EventArgs e)
    //{
    //    Shell.Current.GoToAsync(nameof(AddContactPage));
    //}
}