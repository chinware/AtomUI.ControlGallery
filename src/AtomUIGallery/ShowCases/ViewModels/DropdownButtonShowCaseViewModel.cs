using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class DropdownButtonShowCaseViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "DropdownButtonShowCase";
    
    public IScreen HostScreen { get; }
    
    public string UrlPathSegment { get; } = ID;

    public DropdownButtonShowCaseViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}