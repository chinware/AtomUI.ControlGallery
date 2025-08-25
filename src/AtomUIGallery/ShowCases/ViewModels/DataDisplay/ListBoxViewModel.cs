using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class ListBoxViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "ListBox";
    
    public IScreen HostScreen { get; }
    
    public string UrlPathSegment { get; } = ID;

    public ListBoxViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}