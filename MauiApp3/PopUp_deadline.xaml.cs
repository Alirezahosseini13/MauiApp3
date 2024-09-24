using System;
using System.Globalization;
using CommunityToolkit.Maui.Views;
using Microsoft.Maui.Controls;

namespace MauiApp3;

public partial class PopUp_deadline : Popup
{
	public PopUp_deadline()
	{
		InitializeComponent();
	}

    private async void OnSaveButtonClicked(object sender, EventArgs e)
    {
       /* try
        {
            // Get the selected time
            var selectedTime = TimePicker.Time;

            // Format the time for display
            string formattedTime = selectedTime.ToString(@"hh\:mm tt"); // 12-hour format

            // Display an alert with the selected time
            DisplayAlert("Selected Time", $"You selected: {formattedTime}", "OK");
        }
        catch (Exception ex)
        {
            // Handle any exceptions that may occur
            DisplayAlert("Error", $"An error occurred: {ex.Message}", "OK");
        }*/
    }
}