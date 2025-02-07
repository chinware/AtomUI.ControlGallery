using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class WatermarkShowCaseViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "WatermarkShowCase";
    
    public IScreen HostScreen { get; }
    
    public string UrlPathSegment { get; } = ID;

    public WatermarkShowCaseViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}