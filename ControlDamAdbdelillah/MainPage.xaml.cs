namespace ControlDamAdbdelillah;

public partial class MainPage : ContentPage
{
    private const string CorrectPassword = "DAM2024";
    public static int Counter = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    async void OnLoginButtonClicked(object sender, EventArgs e)
    {
        if (PasswordEntry.Text == CorrectPassword)
        {
            Counter++;
            await Shell.Current.GoToAsync("//SecondPage");
        }
        else
        {
            await DisplayAlert("Error", "Incorrect password, try again.", "OK");
        }
    }
}