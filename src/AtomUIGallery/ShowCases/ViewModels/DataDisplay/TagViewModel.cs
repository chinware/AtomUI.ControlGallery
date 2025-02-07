using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class TagViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "TagShowCase";
    
    public IScreen HostScreen { get; }
    
    public string UrlPathSegment { get; } = ID;

    public TagViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}