using System.Collections.ObjectModel;
namespace MauiApp3;

public partial class GroupPage : ContentPage
{
    public ObservableCollection<Groups> group { get; set; }
    public GroupPage()
	{
		InitializeComponent();
        group = new ObservableCollection<Groups>();

        for (int i = 0; i < 20; i++)
        {
            group.Add(new Groups("design", "qwertyuiop[asdfghjkl;zxcvbnm,"));
        }

        BindingContext = this;
    }

   async private void Addgrp_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AddgrpPage());
    }

    async private void InformGroup_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        await Navigation.PushAsync(new InformGroupPage());
    }
}