using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

using TelecomNevaService.Desktop.Commands;
using TelecomNevaService.Desktop.Models;
using TelecomNevaService.Desktop.Views.Controls;
using TelecomNevaService.Desktop.Views.Windows;

namespace TelecomNevaService.Desktop.ViewModels;

internal class ClientsPageViewModel : BaseViewModel
{
    private readonly TelecomNevaServiceModel _context = new();
    private LambdaCommand _moveEventsDownCommand;
    private LambdaCommand _moveEventsUpCommand;
    public Window MainWindow { get; set; }

    public ClientsPageViewModel()
    {
        ((MainWindow as MainWindow)?.DataContext as MainWindowViewModel)?.UserComboBoxSelectionChangedCommand.Execute(this);
    }

    #region Commands

    public LambdaCommand MoveEventsDownCommand => 
        _moveEventsDownCommand ??= new LambdaCommand(obj => (obj as ScrollViewer)?.LineDown());

    public LambdaCommand MoveEventsUpCommand => 
        _moveEventsUpCommand ??= new LambdaCommand(obj => (obj as ScrollViewer)?.LineUp());

    #endregion

    #region Properties

    public ObservableCollection<EventItemUserControl> EventItemUserControls { get; } = new();

    #endregion
}