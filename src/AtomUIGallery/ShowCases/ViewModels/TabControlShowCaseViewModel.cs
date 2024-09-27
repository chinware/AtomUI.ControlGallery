using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class TabControlShowCaseViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "TabControlShowCase";
    
    public IScreen HostScreen { get; }
    
    public string UrlPathSegment { get; } = ID;

    public TabControlShowCaseViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}