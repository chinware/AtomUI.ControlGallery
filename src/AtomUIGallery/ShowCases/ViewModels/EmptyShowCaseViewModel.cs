using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class EmptyShowCaseViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "EmptyShowCase";
    
    public IScreen HostScreen { get; }
    
    public string UrlPathSegment { get; } = ID;

    public EmptyShowCaseViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}