using TelecomNevaService.Authorization.ViewModels;

namespace TelecomNevaService.Authorization.Views.Pages;

public partial class LoginPage
{
    public LoginPage()
    {
        InitializeComponent();
        DataContext = new LoginPageViewModel
        {
            UserLoginTextBox = LoginTextBox,
            UserPasswordBox = PasswordBox,
            InputedCaptchaTextBox = CaptchaTextBox,
            GetNewCodeButton = GetNewCodeButton,
            LoginButton = LoginButton
        };
    }
}