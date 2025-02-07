using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class DrawerViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "DrawerShowCase";
    
    public IScreen HostScreen { get; }
    
    public string UrlPathSegment { get; } = ID;

    public DrawerViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}