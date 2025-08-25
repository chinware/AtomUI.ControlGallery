using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class DrawerViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "Drawer";
    
    public IScreen HostScreen { get; }
    
    public string UrlPathSegment { get; } = ID;

    public DrawerViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}