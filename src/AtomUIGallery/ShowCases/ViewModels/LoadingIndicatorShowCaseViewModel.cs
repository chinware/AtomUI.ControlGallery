using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class LoadingIndicatorShowCaseViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "LoadingIndicatorShowCase";
    
    public IScreen HostScreen { get; }
    
    public string UrlPathSegment { get; } = ID;

    public LoadingIndicatorShowCaseViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}