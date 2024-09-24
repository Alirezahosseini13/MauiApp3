using CommunityToolkit.Maui.Views;
using System.Collections.ObjectModel;

namespace MauiApp3;

public partial class ShowprofilePage : ContentPage
{

    public ShowprofilePage()
	{
		InitializeComponent();

       
    }
    private  void Whichg_Clicked(object sender, EventArgs e)
    {
         this.ShowPopupAsync(new PopUp_ProfileGroups());

    }

    private void Tasks_Clicked(object sender, EventArgs e)
    {
        this.ShowPopupAsync(new PopUp_ProfileTasks());

    }



    async private void editadmin_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new editadminPage());

    }
}