using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class LineEditShowCaseViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "LineEditShowCase";
    
    public IScreen HostScreen { get; }
    
    public string UrlPathSegment { get; } = ID;

    public LineEditShowCaseViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}