namespace Contacts.Maui.Views.Controls;

public partial class ContactControl : ContentView
{
	public ContactControl()
	{
		InitializeComponent();
	}
    public event EventHandler<string> OnError;
    public event EventHandler<EventArgs> OnSave;
    public event EventHandler<EventArgs> OnCancel;


    public string Name
	{
		get
		{
			return entryName.Text;	
				
		}
		set
		{
			entryName.Text = value;
		}
	}
    public string Email
    {
        get
        {
            return entryEmail.Text;

        }
        set
        {
            entryEmail.Text = value;
        }
    }
    public string Department
    {
        get
        {
            return entryDepartment.Text;

        }
        set
        {
            entryDepartment.Text = value;
        }
    }
    public string AddressStreet
    {
        get
        {
            return entryAddressStreet.Text;

        }
        set
        {
            entryAddressStreet.Text = value;
        }
    }
    public string AddressCity
    {
        get
        {
            return entryAddressCity.Text;

        }
        set
        {
            entryAddressCity.Text = value;
        }
    }
    public string AddressState
    {
        get
        {
            return entryAddressState.Text;

        }
        set
        {
            entryAddressState.Text = value;
        }
    }
    public string AddressZip
    {
        get
        {
            return entryAddressZip.Text;

        }
        set
        {
            entryAddressZip.Text = value;
        }
    }
    public string AddressCountry
    {
        get
        {
            return entryAddressCountry.Text;

        }
        set
        {
            entryAddressCountry.Text = value;
        }
    }
    public string Phone
    {
        get
        {
            return entryPhone.Text;

        }
        set
        {
            entryPhone.Text = value;
        }
    }

    private void btnSave_Clicked(object sender, EventArgs e)
    {
        if (nameValidator.IsNotValid)
        {
            OnError?.Invoke(sender, "Name is required");
            return;
        }

        if (emailValidator.IsNotValid)
        {
            foreach (var error in emailValidator.Errors)
            {
                OnError?.Invoke(sender, error.ToString());
            }
            return;
        }

        OnSave?.Invoke(sender, e);
    }

    private void btnCancel_Clicked(object sender, EventArgs e)
    {
        OnCancel?.Invoke(sender, e);
    }
}