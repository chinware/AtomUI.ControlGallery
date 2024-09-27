using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class ButtonShowCaseViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "ButtonShowCase";
    
    public IScreen HostScreen { get; }
    
    public string UrlPathSegment { get; } = ID;

    public ButtonShowCaseViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}