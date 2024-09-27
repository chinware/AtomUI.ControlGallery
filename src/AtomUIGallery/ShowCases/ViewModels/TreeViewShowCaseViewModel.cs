using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class TreeViewShowCaseViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "TreeViewShowCase";
    
    public IScreen HostScreen { get; }
    
    public string UrlPathSegment { get; } = ID;

    public TreeViewShowCaseViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}