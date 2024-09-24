using System.Collections.ObjectModel;
using CommunityToolkit.Maui.Views;

namespace MauiApp3;

public partial class SubDomainPage : ContentPage
{
    public ObservableCollection<Domains> domains { get; set; }

    public ObservableCollection<Groups> group { get; set; }

    public ObservableCollection<Tasks> tasks { get; set; }

    public SubDomainPage()
	{
		InitializeComponent();

        domains = new ObservableCollection<Domains>();

        for (int i = 0; i < 20; i++)
        {
            domains.Add(new Domains("CPSA"));
        }
        
    

        group = new ObservableCollection<Groups>();

        for (int i = 0; i < 20; i++)
        {
            group.Add(new Groups("design", "qwertyuiop[asdfghjkl;zxcvbnm,"));
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
        
    } 

    async private void Addgrp_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AddgrpPage());
    }

    private void Addtsk_Clicked(object sender, EventArgs e)
    {
        this.ShowPopupAsync(new PopUpTaskList());
    }

    async private void ShowTskGroup_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        await Navigation.PushAsync(new ShowTaskInformationPage());
    }
    async private void InformGroup_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        await Navigation.PushAsync(new InformGroupPage2());
    }
}