using Contacts.Maui.ViewModels;

namespace Contacts.Maui.Views_MVVM;

[QueryProperty(nameof(ContactId), "Id")]
public partial class ViewContactPage_MVVM : ContentPage
{
    private readonly ContactViewModel contactViewModel;
    public ViewContactPage_MVVM(ContactViewModel contactViewModel)
	{
		InitializeComponent();
        this.contactViewModel = contactViewModel;

        this.BindingContext = this.contactViewModel;
    }
    public string ContactId
    {
        set
        {
            if (!string.IsNullOrWhiteSpace(value) && int.TryParse(value, out int contactId))
            {
                LoadContact(contactId);
            }
        }
    }

    private async void LoadContact(int contactId)
    {
        await this.contactViewModel.LoadContact(contactId);
    }
}