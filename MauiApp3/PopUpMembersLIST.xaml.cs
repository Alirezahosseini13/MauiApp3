using CommunityToolkit.Maui.Views;
using System.Collections.ObjectModel;
namespace MauiApp3;

public partial class PopUpMembersLIST : Popup
{
    public ObservableCollection<Users> users { get; set; }

    public PopUpMembersLIST()
    {
        InitializeComponent();
        users = new ObservableCollection<Users>();

        for (int i = 0; i < 20; i++)
        {
            users.Add(new Users("Resources/Iimages/user1", "shqayeq", null));
        }

        BindingContext = this;
    }



    async private void Adduse_Clicked(object sender, EventArgs e)
    {
    }
}