using System;
using Microsoft.Maui.Controls;

namespace MauiApp3
{
    public partial class HamburgerPage : FlyoutPage
    {
        public HamburgerPage()
        {
            InitializeComponent();
        }

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

}