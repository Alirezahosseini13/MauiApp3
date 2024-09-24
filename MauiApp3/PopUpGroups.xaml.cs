using CommunityToolkit.Maui.Views;
using System.Collections.ObjectModel;
namespace MauiApp3;

public partial class PopUpGroups : Popup
{
    public ObservableCollection<Groups> group { get; set; }
    public PopUpGroups()
    {
        InitializeComponent();
        group = new ObservableCollection<Groups>();

        for (int i = 0; i < 20; i++)
        {
            group.Add(new Groups("design", null));
        }

        BindingContext = this;
    }

    async private void Addgrp_Clicked(object sender, EventArgs e)
    {

    }
}