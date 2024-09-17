using CommunityToolkit.Maui.Views;
namespace MauiApp3;

public partial class TaskInformationPage : ContentPage
{
	public TaskInformationPage()
	{
		InitializeComponent();
	}
    private void Button_Clicked(object sender, EventArgs e)
    {
        Button button = sender as Button;
        string buttonText = button.Text;
        switch (button.Text)
        {
            case "Assign To ":
                AssignToPerson();
                break;
            case "Deadline":
                SetDeadline();
                break;
            case "Created By":
                SetCreatedBy();
                break;
            case "Previous Task":
                GoToPreviousTask();
                break;
            case "Next Task":
                GoToNextTask();
                break;
            case "Manager":
                ShowManager();
                break;
            case "Couple":
                ShowCouple();
                break;
            case "Priority":
                SetPriority();
                break;
            case "Start Time":
                SetDeadline();
                break;
            case "End Time":
                SetDeadline();
                break;
            case "Sleep Time":
                SetDeadline();
                break;
            case "Prerequisite":
                SetPrerequisite();
                break;
            default:
                break;
        }
    }
     private void SetPrerequisite()
    {
        this.ShowPopupAsync(new PopUp_FileUploadPage());

    }

    async private void AssignToPerson()
    {
        await Navigation.PushAsync(new AssingPage());
    }

    private void SetDeadline()
    {
        this.ShowPopupAsync(new PopUp_deadline());
    }

    private void SetCreatedBy()
    {
        this.ShowPopupAsync(new PopUpMembersLIST());

    }

    private void GoToPreviousTask()
    {
        this.ShowPopupAsync(new PopUpTaskList());

    }

    private void GoToNextTask()
    {

        this.ShowPopupAsync(new PopUpTaskList());

    }

    private void ShowManager()
    {
        this.ShowPopupAsync(new PopUpMembersLIST());

    }

    private void ShowCouple()
    {
        this.ShowPopupAsync(new PopUpTaskList());

    }

    private void SetPriority()
    {
        this.ShowPopupAsync(new PopUp_priority ());
    }



    async private void Addtsk_Clicked(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(nameTaskEntry.Text))
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