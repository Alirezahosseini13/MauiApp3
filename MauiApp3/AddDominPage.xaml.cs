using CommunityToolkit.Maui.Views;
namespace MauiApp3;

public partial class AddDominPage : ContentPage
{
	public AddDominPage()
	{
		InitializeComponent();
	}

    private void DOMAINS_Clicked(object sender, EventArgs e)
    {
     this.ShowPopupAsync(new PopUpDomainList());
    }

    private void GROUPS_Clicked_1(object sender, EventArgs e)
    {
     this.ShowPopupAsync(new PopUpGroups());
    }

    private void Add_Clicked_2(object sender, EventArgs e)
    {

    }

    private void ADMIN_Clicked_3(object sender, EventArgs e)
    {
     this.ShowPopupAsync(new PopUpMembersLIST());
    }
}