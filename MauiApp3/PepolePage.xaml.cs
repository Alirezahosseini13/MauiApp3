//using CommunityToolkit.Maui.Views;
using CommunityToolkit.Maui.Views;
using System;
using System.Collections.ObjectModel;
//using static Java.Util.Jar.Attributes;

 namespace MauiApp3;

   public partial class PepolePage : ContentPage
   {
    public ObservableCollection<Users> useers { get; set; }

     
    public PepolePage()
    {
        InitializeComponent();

        useers = new ObservableCollection<Users>();

        for(int i=0; i<20; i++)
        {
            useers.Add(new Users("Resources/Iimages/user1" , "shqayeq" , "more"));
        }

        BindingContext = this;
    }

    
    

    async private void Button_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new GroupPage());
	}



    async private void Adduse_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AdduPage());
    }



    async private void Showprofile_Tapped(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new ShowprofilePage());
    }



    private void Showmore_Tapped(object sender, TappedEventArgs e)
    {
     this.ShowPopupAsync(new PopUp());
    }



    private void OnDeleteItem(object sender, EventArgs e)
    {
        
        var swipeItem = (SwipeItem)sender;
        
        var users = (Users)swipeItem.BindingContext;

        
        useers.Remove(users);
    }
   }
