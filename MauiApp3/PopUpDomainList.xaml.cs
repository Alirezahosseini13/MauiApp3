using CommunityToolkit.Maui.Views;
using System.Collections.ObjectModel;
namespace MauiApp3;

public partial class PopUpDomainList : Popup
{
    public ObservableCollection<Domains> domains { get; set; }
    public PopUpDomainList()
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

    async private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        //this.ShowPopupAsync(new PopUp_AccessLevel());
       
    }
}