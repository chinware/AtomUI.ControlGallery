using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class PaletteShowCaseViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "PaletteShowCase";
    
    public IScreen HostScreen { get; }
    
    public string UrlPathSegment { get; } = ID;

    public PaletteShowCaseViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}