using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class CalendarShowCaseViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "CalendarShowCase";
    
    public IScreen HostScreen { get; }
    
    public string UrlPathSegment { get; } = ID;

    public CalendarShowCaseViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}