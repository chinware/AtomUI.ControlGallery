using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class PopupConfirmShowCaseViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "PopupConfirmShowCase";
    
    public IScreen HostScreen { get; }
    
    public string UrlPathSegment { get; } = ID;

    public PopupConfirmShowCaseViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}