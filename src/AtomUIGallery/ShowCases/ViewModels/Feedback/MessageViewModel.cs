using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class MessageViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "MessageShowCase";
    
    public IScreen HostScreen { get; }
    
    public string UrlPathSegment { get; } = ID;

    public MessageViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}