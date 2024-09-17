using CommunityToolkit.Maui.Views;

namespace MauiApp3;

public partial class AdduPage : ContentPage
{
	public AdduPage()
	{
		InitializeComponent();

        var jobList = new List<String>();
        jobList.Add("Programmer");
        jobList.Add("NetWork Expert");
        jobList.Add("CEO");

        pickerjob.ItemsSource = jobList;
    }

    async private void Prof_Clicked(object sender, EventArgs e)
    {
    }

    private void Whichg_Clicked(object sender, EventArgs e)
    {
        this.ShowPopupAsync(new PopUpGroups());

    }


    async private void Addus_Clicked(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(usernameEntry.Text) && !string.IsNullOrWhiteSpace(userpaswordEntry.Text) && !string.IsNullOrWhiteSpace(usernumberEntry.Text) && pickerjob.SelectedItem != null)
        {
            bool add = await DisplayAlert("confirmation", " are you sure to add it ? ", "OK", "NO");
            if (add)
            {
                await DisplayAlert("SUCCESS", "ADDED SUCCESSFULLY", "OK");
            }
            else
            {
                return;
            }

        }
        else
        {
            await DisplayAlert("error", "please fill in the fields ", "OK");
        }


    }
}