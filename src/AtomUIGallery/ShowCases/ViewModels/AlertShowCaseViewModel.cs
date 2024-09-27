using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class AlertShowCaseViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "AlertShowCase";
    
    public IScreen HostScreen { get; }
    
    public string UrlPathSegment { get; } = ID;

    public AlertShowCaseViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}