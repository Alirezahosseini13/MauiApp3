using CommunityToolkit.Maui.Views;
using System.Collections.ObjectModel;
namespace MauiApp3;

public partial class PopUp_FileUploadPage : Popup
{
    private string selectedFilePath;
    public ObservableCollection<Users> users { get; set; }
    public PopUp_FileUploadPage()
	{
		InitializeComponent();

        users = new ObservableCollection<Users>();

        for (int i = 0; i < 20; i++)
        {
            users.Add(new Users("Resources/Iimages/user1", "shqayeq", null));
        }

        BindingContext = this;
    }
    private async void OnSelectFileClicked(object sender, EventArgs e)
    {
        try
        {
            var result = await FilePicker.PickAsync(new PickOptions
            {
                PickerTitle = "Pick a file"
            });

            if (result != null)
            {
                selectedFilePath = result.FullPath;
                UploadButton.IsEnabled = true;
                StatusLabel.Text = $"Selected: {result.FileName}";
            }
        }
        catch (Exception ex)
        {
            StatusLabel.Text = $"Error picking file: {ex.Message}";
        }
    }

    private async void OnUploadFileClicked(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(selectedFilePath))
        {
            StatusLabel.Text = "No file selected.";
            return;
        }

        try
        {
            using var httpClient = new HttpClient();
            using var formContent = new MultipartFormDataContent();

            using var fileStream = new FileStream(selectedFilePath, FileMode.Open, FileAccess.Read);
            using var streamContent = new StreamContent(fileStream);

            // Replace "file" with your server's expected form field name
            formContent.Add(streamContent, "file", Path.GetFileName(selectedFilePath));

            var response = await httpClient.PostAsync("https://yourserver.com/upload", formContent);

            if (response.IsSuccessStatusCode)
            {
                StatusLabel.Text = "File uploaded successfully!";
            }
            else
            {
                StatusLabel.Text = $"Upload failed: {response.ReasonPhrase}";
            }
        }
        catch (Exception ex)
        {
            StatusLabel.Text = $"Error uploading file: {ex.Message}";
        }
    }
    private void Button_Clicked(object sender, EventArgs e)
    {

    }
}