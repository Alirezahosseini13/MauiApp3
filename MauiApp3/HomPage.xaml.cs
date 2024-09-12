namespace MauiApp3;

public partial class HomPage : ContentPage
{
	public HomPage()
	{
		InitializeComponent();
        
	}

    



    async private void peopleButton(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new PepolePage());
    }

    async private void domainButton(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new DomainPage());
    }

    async private void taskButton(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new TaskPage());
    }
}