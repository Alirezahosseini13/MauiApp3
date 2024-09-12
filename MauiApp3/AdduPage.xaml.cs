using CommunityToolkit.Maui.Views;

namespace MauiApp3;

public partial class AdduPage : ContentPage
{
	public AdduPage()
	{
		InitializeComponent();
	}

    async private void Prof_Clicked(object sender, EventArgs e)
    {
    }

    private void Whichg_Clicked(object sender, EventArgs e)
    {
        this.ShowPopupAsync(new PopUpGroups());

    }


    async private void Addus_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("SUCCESS", "ADDED SUCCESSFULLY", "OK");

    }
}