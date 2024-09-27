using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class TagShowCaseViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "TagShowCase";
    
    public IScreen HostScreen { get; }
    
    public string UrlPathSegment { get; } = ID;

    public TagShowCaseViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}