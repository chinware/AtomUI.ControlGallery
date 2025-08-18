using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class NotificationViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "Notification";
    
    public IScreen HostScreen { get; }
    
    public string UrlPathSegment { get; } = ID;

    public NotificationViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}