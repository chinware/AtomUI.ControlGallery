using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class SplitButtonShowCaseViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "SplitButtonShowCase";
    
    public IScreen HostScreen { get; }
    
    public string UrlPathSegment { get; } = ID;

    public SplitButtonShowCaseViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}