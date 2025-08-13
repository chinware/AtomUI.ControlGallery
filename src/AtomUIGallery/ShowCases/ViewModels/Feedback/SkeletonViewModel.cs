using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class SkeletonViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "SkeletonShowCase";
    
    public IScreen HostScreen { get; }
    
    public string UrlPathSegment { get; } = ID;

    public SkeletonViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}