using CommunityToolkit.Maui.Views;

namespace MauiApp3;

public partial class PopUpcouple : Popup
{
	public PopUpcouple()
	{
		InitializeComponent();

     }

    void OnTextChanged(object sender, EventArgs e)
    {
        SearchBar searchBar = (SearchBar)sender;
    }

    private void Addcouple_Clicked(object sender, EventArgs e)
    {

    }
}
