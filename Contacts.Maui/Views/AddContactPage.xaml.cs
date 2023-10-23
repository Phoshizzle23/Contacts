namespace Contacts.Maui.Views;

using Contacts.Maui.Models;
using Contacts.UseCases.Interfaces;
using Contact = Contacts.CoreBusiness.Contact;

public partial class AddContactPage : ContentPage
{
    private readonly IAddContactUseCase addContactUseCase;

    public AddContactPage(IAddContactUseCase addContactUseCase)
	{
		InitializeComponent();
        this.addContactUseCase = addContactUseCase;
    }

      

    private async void contactCtrl_OnSave_1(object sender, EventArgs e)
    {
        
        
        await addContactUseCase.ExecuteAsync(new Contact
        {
            Name = contactCtrl.Name,
            Email = contactCtrl.Email,
            Phone = contactCtrl.Phone,
            Department = contactCtrl.Department,
            AddressStreet = contactCtrl.AddressStreet,
            AddressState = contactCtrl.AddressState,
            AddressCity = contactCtrl.AddressCity,
            AddressZip = contactCtrl.AddressZip,
            AddressCountry = contactCtrl.AddressCountry
        });


        await Shell.Current?.GoToAsync("..");
    }

    private void contactCtrl_OnCancel(object sender, EventArgs e)
    {
        Shell.Current?.GoToAsync("..");
    }

    private void contactCtrl_OnError(object sender, string e)
    {
        DisplayAlert("ERROR!!!", e, "OK");
    }
}