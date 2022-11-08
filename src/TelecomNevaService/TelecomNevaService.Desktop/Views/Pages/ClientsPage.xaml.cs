using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

using TelecomNevaService.Desktop.Classes;
using TelecomNevaService.Desktop.Models;
using TelecomNevaService.Desktop.ViewModels;
using TelecomNevaService.Desktop.Views.Controls;

namespace TelecomNevaService.Desktop.Views.Pages;

public partial class ClientsPage
{
    private readonly TelecomNevaServiceModel _context;
    private UserRecord _selectedUser;
    public Window MainWindow { get; set; }

    public ClientsPage()
    {
        InitializeComponent();
        DataContext = new ClientsPageViewModel { MainWindow = MainWindow };
        _context = new();
        InfoCatcher.ModuleHeaderLabel.Content = Title;
        if (_selectedUser != null)
        {
            var dbEvents = _context.StaffInfo.Where(si => si.UserRoleID == _selectedUser.UserRoleId)
                .OrderBy(sie => sie.EventDatetime).ToList();
            var events = new List<EventItemUserControl>();

            foreach (var dbEvent in dbEvents)
            {
                events.Add(new EventItemUserControl
                {
                    DataContext = new EventItemUserControlViewModel
                        {EventText = dbEvent.InfoText, EventTime = dbEvent.EventDatetime.ToShortTimeString()}
                });
            }

            EventsStackPanel.Children.Clear();

            foreach (var eventItem in events)
                EventsStackPanel.Children.Add(eventItem);
        }
        else
            LoadUserEvents();
    }

    private void LoadUserEvents()
    {
        InfoCatcher.UserComboBox.SelectionChanged += UserComboBox_SelectionChanged;
    }

    private async void UserComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if ((sender as ComboBox)?.SelectedItem is UserRecord selectedUser)
        {
            _selectedUser = selectedUser;
            var dbEvents = await _context.StaffInfo.Where(si => si.UserRoleID == selectedUser.UserRoleId)
                .OrderBy(sie => sie.EventDatetime).ToListAsync();
            var events = new List<EventItemUserControl>();

            foreach (var dbEvent in dbEvents)
            {
                events.Add(new EventItemUserControl
                {
                    DataContext = new EventItemUserControlViewModel
                        {EventText = dbEvent.InfoText, EventTime = dbEvent.EventDatetime.ToShortTimeString()}
                });
            }

            EventsStackPanel.Children.Clear();

            foreach (var eventItem in events)
                EventsStackPanel.Children.Add(eventItem);
        }
    }
}