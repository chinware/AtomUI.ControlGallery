using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class SplitButtonViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "SplitButtonShowCase";
    
    public IScreen HostScreen { get; }
    
    public string UrlPathSegment { get; } = ID;

    public SplitButtonViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}