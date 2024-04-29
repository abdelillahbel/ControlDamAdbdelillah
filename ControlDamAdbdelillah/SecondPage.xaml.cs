using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDamAdbdelillah;

public partial class SecondPage : ContentPage
{
    public SecondPage()
    {
        InitializeComponent();
        WelcomeLabel.Text = $"Nice, welcome! You've logged in {MainPage.Counter} times.";
    }

    async void OnBackButtonClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//MainPage");
    }
}