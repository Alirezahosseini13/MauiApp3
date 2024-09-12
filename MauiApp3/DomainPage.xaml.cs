using CommunityToolkit.Maui.Views;
using System.Collections.ObjectModel;
namespace MauiApp3;
public partial class DomainPage : ContentPage
{

    public ObservableCollection<Domains> domains { get; set; }
    public ObservableCollection<Tasks> tasks { get; set; }


    public DomainPage()
	{
		InitializeComponent();
        domains = new ObservableCollection<Domains>();

        for (int i = 0; i < 20; i++)
        {
            domains.Add(new Domains("CPSA"));
        }


        tasks = new ObservableCollection<Tasks>();
        for (int i = 0; i < 20; i++)
        {
            tasks.Add(new Tasks("name task ..."));
        }

        BindingContext = this;
    }

    async private void AddDomain_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AddDominPage());
    }

    private void ShowSubDomain_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {

    }

    async private void Addtsk_Clicked(object sender, EventArgs e)
    {
     this.ShowPopupAsync(new PopUpTaskList());  
    }

    async private void ShowTskGroup_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
     this.ShowPopupAsync(new PopUpTask1());
    }
}