using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class MessageViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "Message";
    
    public IScreen HostScreen { get; }
    
    public string UrlPathSegment { get; } = ID;

    public MessageViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}