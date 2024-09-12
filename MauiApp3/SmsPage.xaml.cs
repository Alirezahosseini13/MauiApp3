namespace MauiApp3;

public partial class SmsPage : ContentPage
{
	public SmsPage()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        timerFunc();
    }
    private async Task timerFunc()
    {
        for (int i = 1; i >= 0; i--)
        {
            for (int j = 59; j >= 0; j--)
            {
                timerLabel.Text = $"{i}:{j}";
                await Task.Delay(1000);
            }
        }
    }

    string tempsms = "12345";
    

    private void loginButton(object sender, EventArgs e)
    {
        string tempsms = smsEntry.Text;
        
        if (smsEntry.Text == tempsms )
        {
            App.Current.MainPage = new  NavigationPage (new HomPage());
        }
        else
        {
            DisplayAlert("Stupid", "UserName or Password Wrong :/", "Bedeh SHihs");
        }
    }
}