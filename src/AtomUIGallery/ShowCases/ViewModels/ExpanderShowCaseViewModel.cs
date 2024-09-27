using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class ExpanderShowCaseViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "ExpanderShowCase";
    
    public IScreen HostScreen { get; }
    
    public string UrlPathSegment { get; } = ID;

    public ExpanderShowCaseViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}