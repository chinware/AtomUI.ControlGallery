using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class MessageShowCaseViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "MessageShowCase";
    
    public IScreen HostScreen { get; }
    
    public string UrlPathSegment { get; } = ID;

    public MessageShowCaseViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}