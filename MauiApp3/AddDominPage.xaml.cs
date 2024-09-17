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

    async private void Add_Clicked_2(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(nameDomEntry.Text) && !string.IsNullOrWhiteSpace(discriptionEntry.Text))
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

    private void ADMIN_Clicked_3(object sender, EventArgs e)
    {
     this.ShowPopupAsync(new PopUpMembersLIST());
    }
}