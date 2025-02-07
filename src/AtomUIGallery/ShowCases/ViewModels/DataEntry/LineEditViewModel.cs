using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class LineEditViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "LineEditShowCase";
    
    public IScreen HostScreen { get; }
    
    public string UrlPathSegment { get; } = ID;

    public LineEditViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}