using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class ComboBoxShowCaseViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "ComboBoxShowCase";
    
    public IScreen HostScreen { get; }
    
    public string UrlPathSegment { get; } = ID;

    public ComboBoxShowCaseViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}