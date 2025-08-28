using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class BoxPanelViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "BoxPanelShowCase";
    
    public IScreen HostScreen { get; }
    
    public string UrlPathSegment { get; } = ID;

    public BoxPanelViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}