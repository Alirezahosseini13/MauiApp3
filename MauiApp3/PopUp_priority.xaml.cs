using CommunityToolkit.Maui.Views;
namespace MauiApp3;

public partial class PopUp_priority : Popup
{
	public PopUp_priority()
    {
        InitializeComponent();
        ImportanceLabel.Text = "سطح اهمیت: 0"; // مقدار اولیه
        
    }

    private void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
    {
        // به‌روزرسانی برچسب و رنگ پس‌زمینه
        ImportanceLabel.Text = $"Level of importance : {e.NewValue:F0}"; // نمایش به صورت عدد صحیح
       
    }

    

    private void OnSaveButtonClicked(object sender, EventArgs e)
    {
        // نمایش پیام تأیید
        ConfirmationLabel.Text = $"The value of {ImportanceSlider.Value:F0} was saved .";
        ConfirmationLabel.IsVisible = true;
    }
}

