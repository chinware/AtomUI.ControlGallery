using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class TimePickerShowCaseViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "TimePickerShowCase";
    
    public IScreen HostScreen { get; }
    
    public string UrlPathSegment { get; } = ID;

    public TimePickerShowCaseViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}