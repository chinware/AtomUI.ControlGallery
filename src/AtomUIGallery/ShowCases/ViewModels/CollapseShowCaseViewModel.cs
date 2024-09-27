using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class CollapseShowCaseViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "CollapseShowCase";
    
    public IScreen HostScreen { get; }
    
    public string UrlPathSegment { get; } = ID;

    public CollapseShowCaseViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}