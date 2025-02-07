using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class RadioButtonViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "RadioButtonShowCase";
    
    public IScreen HostScreen { get; }
    
    public string UrlPathSegment { get; } = ID;

    public RadioButtonViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}