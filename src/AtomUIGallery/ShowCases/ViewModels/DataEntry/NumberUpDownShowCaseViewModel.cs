using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class NumberUpDownShowCaseViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "NumberUpDownShowCase";
    
    public IScreen HostScreen { get; }
    
    public string UrlPathSegment { get; } = ID;

    public NumberUpDownShowCaseViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}