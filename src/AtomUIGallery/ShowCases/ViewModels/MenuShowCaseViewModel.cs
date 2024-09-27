using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class MenuShowCaseViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "MenuShowCase";
    
    public IScreen HostScreen { get; }
    
    public string UrlPathSegment { get; } = ID;

    public MenuShowCaseViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}