using CommunityToolkit.Maui.Views;
using System.Collections.ObjectModel;

namespace MauiApp3;

public partial class PopUp_AdminDomain : Popup
{
    public ObservableCollection<Domains> domains { get; set; }
    public PopUp_AdminDomain()
	{
		InitializeComponent();
        domains = new ObservableCollection<Domains>();

        for (int i = 0; i < 20; i++)
        {
            domains.Add(new Domains("CPSA"));
        }
        BindingContext = this;
    }
    async private void AddDomain_Clicked(object sender, EventArgs e)
    {

    }
}