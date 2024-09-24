

namespace MauiApp3;

public partial class HomPage : ContentPage
{
    private bool _isFlyoutVisible = false;
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

    private async void OnMainContentTapped(object sender, EventArgs e)
    {
        // CLOSE MENU AFTER CLICK TO PAGE
        await FlyoutMenu.TranslateTo(-250, 0, 250, Easing.SinIn);
        FlyoutMenu.IsVisible = false;
        _isFlyoutVisible = false;
    }

   private async void Button_Clicked(object sender, EventArgs e)
    {
        if (_isFlyoutVisible)
        {
            //CLOSE MENU
            await FlyoutMenu.TranslateTo(-250, 0, 250, Easing.SinIn);
            FlyoutMenu.IsVisible = false;
        }
        else
        {
            // OPEN MENU
            FlyoutMenu.IsVisible = true;
            await FlyoutMenu.TranslateTo(0, 0, 300, Easing.SinIn);
        }

        _isFlyoutVisible = !_isFlyoutVisible;
    }

  /*  private void Button_Clicked_1(object sender, EventArgs e)
    {

    }

    private void Button_Clicked_2(object sender, EventArgs e)
    {

    }

    private void Button_Clicked_3(object sender, EventArgs e)
    {

    }

    private void Button_Clicked_4(object sender, EventArgs e)
    {

    }

    private void Button_Clicked_5(object sender, EventArgs e)
    {

    }

    private void Button_Clicked_6(object sender, EventArgs e)
    {

    }*/


    private async void GoToGroupsPage(object sender, EventArgs e)
    {
        // Navigate to GroupsPage
        //await Navigation.PushAsync(new GroupsPage());
    }

    private async void GoToTasksPage(object sender, EventArgs e)
    {
        // Navigate to TasksPage
        //  await Navigation.PushAsync(new TasksPage());
    }

    private async void GoToMessagesPage(object sender, EventArgs e)
    {
        // Navigate to MessagesPage
        // await Navigation.PushAsync(new MessagesPage());
    }
}


