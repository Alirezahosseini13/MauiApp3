using System.Collections.ObjectModel;
using CommunityToolkit.Maui.Views;

namespace MauiApp3;

public partial class PopUp_Assing : Popup
{
    public ObservableCollection<Users> users { get; set; }
    public ObservableCollection<Groups> group { get; set; }



    public PopUp_Assing()
	{
		InitializeComponent();
        users = new ObservableCollection<Users>();

        for (int i = 0; i < 20; i++)
        {
            users.Add(new Users("Resources/Iimages/user1", "shqayeq", null));
        }

        group = new ObservableCollection<Groups>();

        for (int i = 0; i < 20; i++)
        {
            group.Add(new Groups("design", null));
        }

        BindingContext = this;
    }

    async private void Addusegrp_Clicked(object sender, EventArgs e)
    {
    }
}