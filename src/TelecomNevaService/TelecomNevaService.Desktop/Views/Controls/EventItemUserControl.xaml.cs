using TelecomNevaService.Desktop.ViewModels;

namespace TelecomNevaService.Desktop.Views.Controls;

public partial class EventItemUserControl
{
    public EventItemUserControl()
    {
        InitializeComponent();
        DataContext = new EventItemUserControlViewModel();
    }
}