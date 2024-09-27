using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class CheckBoxShowCaseViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "CheckBoxShowCase";
    
    public IScreen HostScreen { get; }
    
    public string UrlPathSegment { get; } = ID;

    public CheckBoxShowCaseViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}