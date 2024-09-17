using CommunityToolkit.Maui.Views;

namespace MauiApp3;

public partial class AssingPage : ContentPage
{
	public AssingPage()
	{
		InitializeComponent();
	}
    private void Group_Clicked(object sender, EventArgs e)
    {
     this.ShowPopup(new PopUpGroups());
    }
    private void User_Clicked_1(object sender, EventArgs e)
    {
     this.ShowPopup(new PopUpMembersLIST());
    }
}