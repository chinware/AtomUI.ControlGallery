using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class TimelineViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "TimelineShowCase";
    
    public IScreen HostScreen { get; }
    
    public string UrlPathSegment { get; } = ID;

    public TimelineViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}