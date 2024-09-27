using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class InfoFlyoutShowCaseViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "InfoFlyoutShowCase";
    
    public IScreen HostScreen { get; }
    
    public string UrlPathSegment { get; } = ID;

    public InfoFlyoutShowCaseViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}