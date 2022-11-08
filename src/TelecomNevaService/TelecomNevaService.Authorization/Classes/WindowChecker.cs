using System.Linq;
using System.Windows;

namespace TelecomNevaService.Authorization.Classes;

internal class WindowChecker
{
    public static Window IsWindowOpen<T>(string windowName) where T : Window
    {
        return Application.Current.Windows.OfType<T>().FirstOrDefault(w => w.Name.Equals(windowName));
    }
}