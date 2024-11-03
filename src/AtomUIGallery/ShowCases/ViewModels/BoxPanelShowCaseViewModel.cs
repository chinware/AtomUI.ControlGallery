using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class BoxPanelShowCaseViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "BoxPanelShowCase";
    
    public IScreen HostScreen { get; }
    
    public string UrlPathSegment { get; } = ID;

    public BoxPanelShowCaseViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}