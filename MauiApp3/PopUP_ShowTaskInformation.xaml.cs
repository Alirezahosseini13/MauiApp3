using CommunityToolkit.Maui.Views;
namespace MauiApp3;

public partial class PopUP_ShowTaskInformation : Popup
{
	public PopUP_ShowTaskInformation()
	{
		InitializeComponent();
	}
    
    async private void Moretasck_Clicked(object sender, EventArgs e)
    {
        //await Navigation.PushAsync(new ShowTaskInformationPage());
    }
}