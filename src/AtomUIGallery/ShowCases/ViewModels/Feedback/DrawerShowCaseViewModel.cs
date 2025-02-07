using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class DrawerShowCaseViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "DrawerShowCase";
    
    public IScreen HostScreen { get; }
    
    public string UrlPathSegment { get; } = ID;

    public DrawerShowCaseViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}