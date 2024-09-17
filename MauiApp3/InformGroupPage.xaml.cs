using System.Collections.ObjectModel;
using CommunityToolkit.Maui.Views;

namespace MauiApp3;

public partial class InformGroupPage : ContentPage
{
    public ObservableCollection<Users> users { get; set; }
    public ObservableCollection<Tasks> tasks { get; set; }


    public InformGroupPage()
	{
		InitializeComponent();
        users = new ObservableCollection<Users>();

        for (int i = 0; i < 20; i++)
        {
            users.Add(new Users("Resources/Iimages/user1", "shqayeq", "more"));
        }


        tasks = new ObservableCollection<Tasks>();
        for (int i = 0; i < 20; i++)
        {
            tasks.Add(new Tasks("name task ..."));
        }

        BindingContext = this;
    }

    async private void Showprofile_Tapped(object sender, TappedEventArgs e)
    {
     await Navigation.PushAsync(new ShowprofilePage());
    }

    private void Showmore_Tapped(object sender, TappedEventArgs e)
    {
     this.ShowPopupAsync(new PopUp());
    }

    async private void Adduse_Clicked(object sender, EventArgs e)
    {
     this.ShowPopupAsync(new PopUpMembersLIST());
    }

     private void Addtsk_Clicked(object sender, EventArgs e)
    {
     this.ShowPopupAsync(new PopUpTaskList());
    }

    async private void ShowTskGroup_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {

        await Navigation.PushAsync(new ShowTaskInformationPage());
    }

}