using CommunityToolkit.Maui.Views;
using System.Collections.ObjectModel;
namespace MauiApp3;

public partial class PopUp : CommunityToolkit.Maui.Views.Popup
{
    public ObservableCollection<Tasks> tasks3 { get; set; }
    public ObservableCollection<Tasks> tasks4 { get; set; }
    public PopUp()
	{
		InitializeComponent();
        tasks3 = new ObservableCollection<Tasks>();
        for (int i = 0; i < 10; i++)
        {
            tasks3.Add(new Tasks("name task ..."));
        }
        tasks4 = new ObservableCollection<Tasks>();
        for (int i = 0; i < 10; i++)
        {
            tasks4.Add(new Tasks("name task ..."));
        }
        BindingContext = this;
    }
}