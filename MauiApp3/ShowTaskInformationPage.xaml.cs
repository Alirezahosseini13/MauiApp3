namespace MauiApp3;

public partial class ShowTaskInformationPage : ContentPage
{
	public ShowTaskInformationPage()
	{
		InitializeComponent();
	}

    async private void More_Clicked(object sender, EventArgs e)
    {
         await Navigation.PushAsync(new ShowTaskInformationPage());
    }
}