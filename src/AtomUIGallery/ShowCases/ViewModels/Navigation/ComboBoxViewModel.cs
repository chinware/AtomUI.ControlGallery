using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class ComboBoxViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "ComboBoxShowCase";
    
    public IScreen HostScreen { get; }
    
    public string UrlPathSegment { get; } = ID;

    public ComboBoxViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}