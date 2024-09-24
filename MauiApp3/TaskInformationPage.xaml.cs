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
            case "Previous and Next Task":
                GoToPreviousNextTask();
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
            case "Discription":
                SetDiscription();
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
        this.ShowPopupAsync(new PopUp_Assing());

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

      private void GoToPreviousNextTask()
    {

        this.ShowPopupAsync(new PopUpPreviousNextTask());

    }

    private void ShowManager()
    {
        this.ShowPopupAsync(new PopUpMembersLIST());

    }

    private void ShowCouple()
    {
        this.ShowPopupAsync(new PopUpcouple());

    }

    private void SetPriority()
    {
        this.ShowPopupAsync(new PopUp_priority ());
    }
    private void SetDiscription()
    {
        this.ShowPopupAsync(new PopUp_Discription());

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