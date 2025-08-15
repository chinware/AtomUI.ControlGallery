using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class BreadcrumbViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "BreadcrumbShowCase";
    
    public IScreen HostScreen { get; }
    
    public string UrlPathSegment { get; } = ID;
    
    public BreadcrumbViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}