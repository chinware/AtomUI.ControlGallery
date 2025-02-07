using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class IconShowCaseViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "IconShowCase";
    
    public IScreen HostScreen { get; }
    
    public string UrlPathSegment { get; } = ID;

    public IconShowCaseViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}