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
        await Navigation.PushAsync(new AddgrupPage());
    }
}