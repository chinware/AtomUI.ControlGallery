using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class ButtonSpinnerShowCaseViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "ButtonSpinnerShowCase";
    
    public IScreen HostScreen { get; }
    
    public string UrlPathSegment { get; } = ID;

    public ButtonSpinnerShowCaseViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}