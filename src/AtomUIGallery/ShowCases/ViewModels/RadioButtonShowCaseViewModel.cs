using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class RadioButtonShowCaseViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "RadioButtonShowCase";
    
    public IScreen HostScreen { get; }
    
    public string UrlPathSegment { get; } = ID;

    public RadioButtonShowCaseViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}