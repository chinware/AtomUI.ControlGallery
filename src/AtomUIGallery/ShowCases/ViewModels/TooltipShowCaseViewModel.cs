using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class TooltipShowCaseViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "TooltipShowCase";
    
    public IScreen HostScreen { get; }
    
    public string UrlPathSegment { get; } = ID;

    public TooltipShowCaseViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}