
using CommunityToolkit.Maui.Views;
using System.Collections.ObjectModel;

namespace MauiApp3;

public partial class InformGroupPage2 : ContentPage
{
    public ObservableCollection<Users> users { get; set; }
    public ObservableCollection<Tasks> tasks { get; set; }
    public InformGroupPage2()
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
}
