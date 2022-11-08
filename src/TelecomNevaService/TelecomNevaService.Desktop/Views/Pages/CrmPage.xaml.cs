using System.Windows.Input;

using TelecomNevaService.Desktop.Classes;
using TelecomNevaService.Desktop.Models;

namespace TelecomNevaService.Desktop.Views.Pages;

public partial class CrmPage
{
    private TelecomNevaServiceModel _context;
    private bool _clientExists;
    public CrmPage()
    {
        InitializeComponent();
        _context = new TelecomNevaServiceModel();
        InfoCatcher.ModuleHeaderLabel.Content = Title;
    }

    private async void CrmPageOnKeyDown(object sender, KeyEventArgs e)
    {
        /*if (e.Key == Key.Enter && !string.IsNullOrWhiteSpace(ClientPhoneNumberTextEdit.Text) && !_clientExists)
        {
            // TODO: Send request to DB
            var users = await _context.User
                .Join
                (
                    _context.UserInfo,
                    u => u.UserInfoID,
                    ui => ui.ID,
                    (u, ui) => new UserRecord
                    {
                        Id = u.ID,
                        FirstName = ui.FirstName,
                        Surname = ui.Surname,
                        Patronymic = ui.Patronymic,
                        FullName = ui.Surname + " " + ui.FirstName + " " + ui.Patronymic,
                        BirthDate = ui.BirthDate,
                        PhoneNumber = ui.PhoneNumber,
                        Email = ui.UserEmail,
                        UserRoleId = u.UserRoleID
                    }
                )
                .Join
                (
                    _context.ContractInfo,
                    u => u.Id,
                    ci => ci.UserID,
            
                )
                .Join
                (
                    _context.Equipment
                )
                .Join
                (
                    _context.EquipmentType
                )
                .ToListAsync();
            if (users.Any(u => u.PhoneNumber == ClientPhoneNumberTextEdit.Text))
            {
                _clientExists = true;
                UserSurnameTextBox.IsEnabled = true;
                UserSurnameTextBox.Focus();
            }
            else
            {
                MessageBox.Show("Клиент не найден в базе данных.", "Ошибка!", MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }
        }
        else if (e.Key == Key.Enter && !string.IsNullOrEmpty(UserSurnameTextBox.Text) && _clientExists)
        {
            // TODO: Send request to DB
            if (true)
            {
                var createApplicationWindow = new CreateApplicationWindow
                {
                    Owner = Window.GetWindow(this)
                };
                createApplicationWindow.ShowDialog();
            }
            else
            {
                MessageBox.Show("Клиент с указаным номером телефона и фамилией отсутсвует в базе данных!",
                    "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }*/
    }
}
