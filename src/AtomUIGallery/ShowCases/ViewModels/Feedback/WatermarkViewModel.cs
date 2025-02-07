using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class WatermarkViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "WatermarkShowCase";
    
    public IScreen HostScreen { get; }
    
    public string UrlPathSegment { get; } = ID;

    public WatermarkViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}