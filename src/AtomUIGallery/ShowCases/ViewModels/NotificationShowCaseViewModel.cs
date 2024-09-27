using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class NotificationShowCaseViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "NotificationShowCase";
    
    public IScreen HostScreen { get; }
    
    public string UrlPathSegment { get; } = ID;

    public NotificationShowCaseViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}