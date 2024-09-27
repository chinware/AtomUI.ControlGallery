using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class SeparatorShowCaseViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "SeparatorShowCase";
    
    public IScreen HostScreen { get; }
    
    public string UrlPathSegment { get; } = ID;

    public SeparatorShowCaseViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}