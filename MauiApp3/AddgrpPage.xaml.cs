using CommunityToolkit.Maui.Views;

namespace MauiApp3;

public partial class AddgrpPage : ContentPage
{
	public AddgrpPage()
	{
		InitializeComponent();
	}

    async private void Whichdom_Clicked(object sender, EventArgs e)
    {
        this.ShowPopupAsync(new PopUpDomainList());
    }

    async private void Whichmember_Clicked(object sender, EventArgs e)
    {
      this.ShowPopupAsync(new PopUpMembersLIST());
    }

    async private void Addgrup_Clicked(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(namegrpEntry.Text))
        {
            bool add = await DisplayAlert("confirmation", " are you sure to add it ? ", "OK", "NO");
            if (add)
            {
                await DisplayAlert("SUCCESS", "ADDED SUCCESSFULLY", "OK");
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