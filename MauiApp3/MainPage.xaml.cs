namespace MauiApp3
{
    public partial class MainPage : ContentPage
    {
      
        public MainPage()
        {
            InitializeComponent();
        }

        string tempUsername = "s";
        string tempPassword = "1";

        private void PasswordShow(object sender, EventArgs e)
        {
            passwordEntry.IsPassword = !passwordEntry.IsPassword;
        }

        private void loginButton(object sender, EventArgs e)
        {
            string username = userNameEntry.Text;
            string password = passwordEntry.Text;

            if (username == tempUsername && password == tempPassword)
            {
                App.Current.MainPage = new SmsPage();
            }
            else
            {
                DisplayAlert("ERRR", "UserName or Password Wrong :/", "OK");
            }
        }

        private void forgotPasswordButton(object sender, EventArgs e)
        {
            App.Current.MainPage = new ForgotPassword();
        }
    }

}
