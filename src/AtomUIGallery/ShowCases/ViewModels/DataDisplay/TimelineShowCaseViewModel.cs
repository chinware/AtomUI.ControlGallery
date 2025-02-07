using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class TimelineShowCaseViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "TimelineShowCase";
    
    public IScreen HostScreen { get; }
    
    public string UrlPathSegment { get; } = ID;

    public TimelineShowCaseViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}