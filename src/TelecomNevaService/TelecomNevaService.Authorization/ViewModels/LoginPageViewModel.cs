using System;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

using TelecomNevaService.Authorization.Classes;
using TelecomNevaService.Authorization.Commands;
using TelecomNevaService.Authorization.Models;
using TelecomNevaService.Authorization.Views.Windows;

namespace TelecomNevaService.Authorization.ViewModels;
internal class LoginPageViewModel : BaseViewModel
{
    private const int InputCodeTime = 10;
    private bool _userExists;
    private bool _firstWindowIsOpen;
    private bool _isCodeInvalid;
    private string _code = string.Empty;
    private readonly TelecomNevaServiceModel _context;
    private readonly CodeGenerator _codeGenerator = new();
    private readonly Stopwatch _stopwatch = new();

    public LoginPageViewModel()
    {
        _context = new();
        DispatcherTimer dispatcherTimer = new()
        {
            Interval = TimeSpan.FromSeconds(1)
        };
        dispatcherTimer.Tick += DispatcherTimerOnTick;
        dispatcherTimer.Start();
    }

    private void DispatcherTimerOnTick(object sender, EventArgs e)
    {
        if (WindowChecker.IsWindowOpen<CodeGeneratorWindow>("codeGeneratorWindow") == null && _firstWindowIsOpen)
            _stopwatch.Start();

        if (WindowChecker.IsWindowOpen<CodeGeneratorWindow>("codeGeneratorWindow") == null && _firstWindowIsOpen &&
            _stopwatch.Elapsed.TotalSeconds >= InputCodeTime)
        {
            _code = string.Empty;
            _isCodeInvalid = true;
            _stopwatch.Reset();
        }
    }
    #region Commands

    private LambdaCommand _cancelCommand;
    private LambdaCommand _loginCommand;
    private LambdaCommand _getNewCodeCommand;
    private LambdaCommand _loginPageKeyDownCommnad;

    public LambdaCommand CancelCommand => _cancelCommand ??= new LambdaCommand((obj) =>
    {
        UserLoginTextBox.Text = string.Empty;
        UserPasswordBox.Password = string.Empty;
        InputedCaptchaTextBox.Text = string.Empty;

        UserPasswordBox.IsEnabled = false;
        InputedCaptchaTextBox.IsEnabled = false;
        GetNewCodeButton.IsEnabled = false;
        LoginButton.IsEnabled = false;

        _code = string.Empty;
        _isCodeInvalid = true;
    });

    public LambdaCommand LoginCommand => _loginCommand ??= new LambdaCommand((obj) =>
    {
        if (InputedCaptchaTextBox.Text == _code)
            MessageBox.Show("Вы успешно авторизовались!", "Информация", MessageBoxButton.OK,
                MessageBoxImage.Information);
        else if (_isCodeInvalid)
            MessageBox.Show("Вы ввели недействительный код из СМС!\nЗапросите новый код.", "Ошибка!",
                MessageBoxButton.OK, MessageBoxImage.Error);
        else
            MessageBox.Show("Вы ввели неверный код из СМС!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
    });

    public LambdaCommand GetNewCodeCommand => _getNewCodeCommand ??= new LambdaCommand((obj) =>
    {
        if (WindowChecker.IsWindowOpen<CodeGeneratorWindow>("codeGeneratorWindow") is CodeGeneratorWindow openWindow)
        {
            openWindow.Close();
            CodeGeneratorWindow codeGeneratorWindow = new(_codeGenerator, nameof(codeGeneratorWindow));
            codeGeneratorWindow.Show();
            _code = codeGeneratorWindow.Code;
            _firstWindowIsOpen = true;
        }
        else
        {
            CodeGeneratorWindow codeGeneratorWindow = new(_codeGenerator, nameof(codeGeneratorWindow));
            codeGeneratorWindow.Show();
            _code = codeGeneratorWindow.Code;
            _firstWindowIsOpen = true;
        }
    });

    public LambdaCommand LoginPageKeyDownCommnad => _loginPageKeyDownCommnad ??= new LambdaCommand((obj) =>
    {
        if (!string.IsNullOrEmpty(UserLoginTextBox.Text) &&
            UserPasswordBox.IsEnabled == false)
        {
            if (_context.User.Any(u => u.Login == UserLoginTextBox.Text))
            {
                _userExists = true;
                UserPasswordBox.IsEnabled = true;
                UserPasswordBox.Focus();
            }
            else
            {
                MessageBox.Show("Пользователь не найден в базе данных!", "Внимание!", MessageBoxButton.OK,
                    MessageBoxImage.Warning);
            }
        }
        else if (!string.IsNullOrEmpty(UserPasswordBox.Password) && _userExists)
        {
            if (_context.User.Any(u => u.Password == UserPasswordBox.Password))
            {
                CodeGeneratorWindow codeGeneratorWindow = new(_codeGenerator, nameof(codeGeneratorWindow));
                codeGeneratorWindow.ShowDialog();
                _code = codeGeneratorWindow.Code;
                _firstWindowIsOpen = true;
                InputedCaptchaTextBox.IsEnabled = true;
                GetNewCodeButton.IsEnabled = true;
                LoginButton.IsEnabled = true;
                InputedCaptchaTextBox.Focus();
            }
            else
            {
                MessageBox.Show("Вы ввели неверный пароль!", "Ошибка!", MessageBoxButton.OK,
                    MessageBoxImage.Warning);
            }
        }
    });

    #endregion

    #region Properties

    private PasswordBox _userPasswordBox;
    private TextBox _inputedCaptchaTextBox;
    private Button _getNewCodeButton;
    private Button _loginButton;
    private TextBox _userLoginTextBox;

    public TextBox UserLoginTextBox
    {
        get => _userLoginTextBox;
        set
        {
            _userLoginTextBox = value;
            OnPropertyChanged();
        }
    }
    public PasswordBox UserPasswordBox
    {
        get => _userPasswordBox;
        set
        {
            _userPasswordBox = value;
            OnPropertyChanged();
        }
    }
    public TextBox InputedCaptchaTextBox
    {
        get => _inputedCaptchaTextBox;
        set
        {
            _inputedCaptchaTextBox = value;
            OnPropertyChanged();
        }
    }
    public Button GetNewCodeButton
    {
        get => _getNewCodeButton;
        set
        {
            _getNewCodeButton = value;
            OnPropertyChanged();
        }
    }
    public Button LoginButton
    {
        get => _loginButton;
        set
        {
            _loginButton = value;
            OnPropertyChanged();
        }
    }

    #endregion
}
