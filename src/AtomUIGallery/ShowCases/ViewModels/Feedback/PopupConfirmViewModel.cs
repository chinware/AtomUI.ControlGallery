using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class PopupConfirmViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "PopupConfirmShowCase";
    
    public IScreen HostScreen { get; }
    
    public string UrlPathSegment { get; } = ID;

    public PopupConfirmViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}