using System.Collections.ObjectModel;
namespace MauiApp3;

public partial class TaskPage : ContentPage
{
    public ObservableCollection<Tasks> tasks { get; set; }

    public TaskPage()
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

    async private void ShowTskGroup_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {

    }
}