using System.Collections.ObjectModel;
using CommunityToolkit.Maui.Views;
namespace MauiApp3;

public partial class PopUpPreviousNextTask : Popup
{
    public ObservableCollection<Tasks> tasks { get; set; }

    public PopUpPreviousNextTask()
	{
		InitializeComponent();
        tasks = new ObservableCollection<Tasks>();
        for (int i = 0; i < 20; i++)
        {
            tasks.Add(new Tasks("name task ..."));
        }

        BindingContext = this;
    }
    async private void Addtsk_Clicked(object sender, EventArgs e)
    {

    }
}