namespace MauiApp3;

public partial class ForgotPage : ContentPage
{
	public ForgotPage()
	{
		InitializeComponent();
	}

    private void BACK_Tapped(object sender, TappedEventArgs e)
    {
        App.Current.MainPage = new NavigationPage(new MainPage());

    }

    async private void Logib_Clicked(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(NationalCodeEntry.Text) && !string.IsNullOrWhiteSpace(PhonenumberEntry.Text) )
        {
            bool add = await DisplayAlert("confirmation", " are you sure ? ", "OK", "NO");
            if (add)
            {
                App.Current.MainPage = new NavigationPage(new SmsPage());
            }
            else
            {
                return;
            }

        }
        else
        {
            await DisplayAlert("error", "please fill in the fields ", "OK");
        }



    }
}