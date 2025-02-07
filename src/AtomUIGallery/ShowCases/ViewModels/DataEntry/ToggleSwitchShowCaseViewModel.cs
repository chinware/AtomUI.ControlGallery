using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class ToggleSwitchShowCaseViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "ToggleSwitchShowCase";
    
    public IScreen HostScreen { get; }
    
    public string UrlPathSegment { get; } = ID;

    public ToggleSwitchShowCaseViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}