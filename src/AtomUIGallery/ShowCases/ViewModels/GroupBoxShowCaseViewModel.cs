using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class GroupBoxShowCaseViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "GroupBoxShowCase";
    
    public IScreen HostScreen { get; }
    
    public string UrlPathSegment { get; } = ID;

    public GroupBoxShowCaseViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}