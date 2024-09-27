using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class SliderShowCaseViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "SliderShowCase";
    
    public IScreen HostScreen { get; }
    
    public string UrlPathSegment { get; } = ID;

    public SliderShowCaseViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}