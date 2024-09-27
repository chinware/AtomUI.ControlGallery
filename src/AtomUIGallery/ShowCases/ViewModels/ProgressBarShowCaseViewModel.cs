using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class ProgressBarShowCaseViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "ProgressBarShowCase";
    
    public IScreen HostScreen { get; }
    
    public string UrlPathSegment { get; } = ID;

    public ProgressBarShowCaseViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}