using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class SegmentedShowCaseViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "SegmentedShowCase";
    
    public IScreen HostScreen { get; }
    
    public string UrlPathSegment { get; } = ID;

    public SegmentedShowCaseViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}