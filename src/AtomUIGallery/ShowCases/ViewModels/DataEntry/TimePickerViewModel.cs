using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class TimePickerViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "TimePickerShowCase";
    
    public IScreen HostScreen { get; }
    
    public string UrlPathSegment { get; } = ID;

    public TimePickerViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}