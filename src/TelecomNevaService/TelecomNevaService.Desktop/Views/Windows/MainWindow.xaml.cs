using TelecomNevaService.Desktop.Classes;
using TelecomNevaService.Desktop.ViewModels;

namespace TelecomNevaService.Desktop.Views.Windows;

public partial class MainWindow
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MainWindowViewModel { Frame = MainFrame, MainWindow = this };
        InfoCatcher.ModuleHeaderLabel = HeaderLabel;
        InfoCatcher.UserComboBox = UserComboBox;
    }
}