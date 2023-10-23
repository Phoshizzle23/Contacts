//using Java.Nio.FileNio.Attributes;
using SQLite;



namespace Contacts.Maui;

public partial class UserSettingsPage : ContentPage
{
    private SQLiteAsyncConnection _database;

    
    public UserSettingsPage()
	{
		InitializeComponent();

        // Initialize the SQLite database connection
        var databasePath = Path.Combine(FileSystem.AppDataDirectory, "settings.db");
        _database = new SQLiteAsyncConnection(databasePath);
        _database.CreateTableAsync<UserSet>().Wait();

        // Load the user settings
        LoadUserSettings();
    }
    private async void LoadUserSettings()
    {
        // Check if the user settings already exist in the database
        var existingSettings = await _database.Table<UserSet>().FirstOrDefaultAsync();
        if (existingSettings != null)
        {
            NameEntry.Text = existingSettings.Name;
            AgeEntry.Text = existingSettings.Age.ToString();

            if (existingSettings.lightOrDark)
            {
                togTheme.IsToggled = true;
            }
            else
            {
                togTheme.IsToggled = false;
            }

            var currentTheme = existingSettings.lightOrDark;
            if (currentTheme)
                Application.Current.UserAppTheme = AppTheme.Dark;
            else
                Application.Current.UserAppTheme = AppTheme.Light;
        }
    }

    private async void SaveButton_Clicked(object sender, EventArgs e)
    {
        var name = NameEntry.Text;
        int age = 0;
        int.TryParse(AgeEntry.Text, out age);
        bool theme = togTheme.IsToggled;

        var userSettings = new UserSet
        {
            Name = name,
            Age = age,
            lightOrDark = theme
        };

        await _database.InsertOrReplaceAsync(userSettings);

        // Show a confirmation message
        await DisplayAlert("Success", "User settings saved", "OK");
    }

    //PREFERENCES
    //SWITCH: https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/switch
    private void OnThemeSwitchToggled(object sender, ToggledEventArgs e)
    {
        bool isDarkTheme = e.Value;
        Preferences.Set("DarkThemeOn", isDarkTheme ? "Dark" : "Light");

        // Apply the theme
        if (isDarkTheme)
            Application.Current.UserAppTheme = AppTheme.Dark;
        else
            Application.Current.UserAppTheme = AppTheme.Light;
    }

    private void togSound_Toggled(object sender, ToggledEventArgs e)
    {
        
        
    }

    private void fontSizePicker_SelectedIndexChanged(object sender, EventArgs e)
    {
        var picker = sender as Picker;
        var selectedItem = picker.SelectedItem as string;

        // Get the global font size style from the app resources
        var app = Application.Current;
        var style = app.Resources["GlobalFontSize"] as Style;

        Console.WriteLine($"Selected item: {selectedItem}"); // Line for debugging

        // Set the font size value based on the selected item
        switch (selectedItem)
        {
            case "Small":
                style.Setters[0].Value = 12;
                break;
            case "Medium":
                style.Setters[0].Value = 16;
                break;
            case "Large":
                style.Setters[0].Value = 24;
                break;
        }
    }


}