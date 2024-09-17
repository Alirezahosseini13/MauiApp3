using CommunityToolkit.Maui.Views;
using System.Collections.ObjectModel;

namespace MauiApp3;

public partial class PopUp_ProfileGroups : Popup
{
    public ObservableCollection<Groups> group { get; set; }
    public PopUp_ProfileGroups()
    {
        InitializeComponent();
        group = new ObservableCollection<Groups>();

        for (int i = 0; i < 20; i++)
        {
            group.Add(new Groups("design", null));
        }

        BindingContext = this;
    }
}