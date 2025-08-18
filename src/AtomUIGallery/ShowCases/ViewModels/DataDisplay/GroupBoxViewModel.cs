using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class GroupBoxViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "GroupBox";
    
    public IScreen HostScreen { get; }
    
    public string UrlPathSegment { get; } = ID;

    public GroupBoxViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}