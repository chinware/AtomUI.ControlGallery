using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class SwitchShowCaseViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "SwitchShowCase";
    
    public IScreen HostScreen { get; }
    
    public string UrlPathSegment { get; } = ID;

    public SwitchShowCaseViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}