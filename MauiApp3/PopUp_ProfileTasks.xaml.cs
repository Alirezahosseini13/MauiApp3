using CommunityToolkit.Maui.Views;
using System.Collections.ObjectModel;
namespace MauiApp3;

public partial class PopUp_ProfileTasks : Popup
{
    public ObservableCollection<Tasks> tasks { get; set; }
    
    public PopUp_ProfileTasks()
	{
        InitializeComponent();

        tasks = new ObservableCollection<Tasks>();
        for (int i = 0; i < 10; i++)
        {
            tasks.Add(new Tasks("name task ..."));
        }
        tasks1 = new ObservableCollection<Tasks>();
        for (int i = 0; i < 10; i++)
        {
            tasks1.Add(new Tasks("name task ..."));
        }
        tasks2 = new ObservableCollection<Tasks>();
        for (int i = 0; i < 10; i++)
        {
            tasks2.Add(new Tasks("name task ..."));
        }
        BindingContext = this;
    }
}