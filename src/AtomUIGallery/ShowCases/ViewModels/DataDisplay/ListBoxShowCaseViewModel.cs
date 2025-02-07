using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class ListBoxShowCaseViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "ListBoxShowCase";
    
    public IScreen HostScreen { get; }
    
    public string UrlPathSegment { get; } = ID;

    public ListBoxShowCaseViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}