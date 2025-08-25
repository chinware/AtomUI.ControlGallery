using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class PopupConfirmViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "PopupConfirm";
    
    public IScreen HostScreen { get; }
    
    public string UrlPathSegment { get; } = ID;

    public PopupConfirmViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}