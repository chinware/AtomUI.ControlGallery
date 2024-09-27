using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class BadgeShowCaseViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "BadgeShowCase";
    
    public IScreen HostScreen { get; }
    
    public string UrlPathSegment { get; } = ID;

    public BadgeShowCaseViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}