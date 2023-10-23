using Contacts.Maui.Models;
using Contacts.UseCases.Interfaces;
using Contact = Contacts.Maui.Models.Contact;

namespace Contacts.Maui.Views;

[QueryProperty(nameof(ContactId),"Id")]
public partial class EditContactPage : ContentPage
{
	private CoreBusiness.Contact contact;
    private readonly IViewContactUseCase viewContactUseCase;
    private readonly IEditContactUseCase editContactUseCase;

    public EditContactPage(IViewContactUseCase viewContactUseCase,
        IEditContactUseCase editContactUseCase)
	{
		InitializeComponent();
        this.viewContactUseCase = viewContactUseCase;
        this.editContactUseCase = editContactUseCase;
    }

	private void btnCancel_Clicked(object sender, EventArgs e)
	{
		Shell.Current.GoToAsync("..");
	}

	public string ContactId
	{
		set
		{
			//contact = ContactRepository.GetContactById(int.Parse(value));
            contact = viewContactUseCase.ExecuteAsync(int.Parse(value)).GetAwaiter().GetResult();
			//lblName.Text = contact.Name;
			if (contact != null)
			{
                contactCtrl.Name = contact.Name;
                contactCtrl.Email = contact.Email;
                contactCtrl.Phone = contact.Phone;
                contactCtrl.Department = contact.Department;
                contactCtrl.AddressStreet = contact.AddressStreet;
                contactCtrl.AddressCity = contact.AddressCity;
                contactCtrl.AddressState = contact.AddressState;
                contactCtrl.AddressZip = contact.AddressZip;
                contactCtrl.AddressCountry = contact.AddressCountry;
            }
			
		}
	}

    private async void btnUpdate_Clicked(object sender, EventArgs e)
    {
		contact.Name = contactCtrl.Name;
		contact.Email = contactCtrl.Email;
		contact.Phone = contactCtrl.Phone;
        contact.Department = contactCtrl.Department;
        contact.AddressStreet = contactCtrl.AddressStreet;
        contact.AddressCity = contactCtrl.AddressCity;
        contact.AddressState = contactCtrl.AddressState;
        contact.AddressZip = contactCtrl.AddressZip;
        contact.AddressCountry = contactCtrl.AddressCountry;

        //ContactRepository.UpdateContact(contact.ContactId, contact);
        await editContactUseCase.ExecuteAsync(contact.ContactId, contact);
        await Shell.Current.GoToAsync("..");
    }  

    private void contactCtrl_OnError(object sender, string e)
    {
		DisplayAlert("ERROR!!!", e, "OK");
    }
}