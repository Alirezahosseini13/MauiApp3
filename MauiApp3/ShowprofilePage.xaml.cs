using CommunityToolkit.Maui.Views;

namespace MauiApp3;

public partial class ShowprofilePage : ContentPage
{
	public ShowprofilePage()
	{
		InitializeComponent();
    }
    private void Whichg_Clicked(object sender, EventArgs e)
    {
        this.ShowPopupAsync(new PopUp_ProfileGroups());

    }
    private void Tasks_Clicked(object sender, EventArgs e)
    {
        this.ShowPopupAsync(new PopUp_ProfileTasks());

    }
}