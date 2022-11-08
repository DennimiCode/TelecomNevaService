namespace TelecomNevaService.Desktop.ViewModels;

internal class EventItemUserControlViewModel : BaseViewModel
{
    private string _eventText;
    private string _eventTime;

    #region Properties

    public string EventText
    {
        get => _eventText;
        set
        {
            _eventText = value;
            OnPropertyChanged();
        }
    }

    public string EventTime
    {
        get => _eventTime;
        set
        {
            _eventTime = value;
            OnPropertyChanged();
        }
    }

    #endregion
}