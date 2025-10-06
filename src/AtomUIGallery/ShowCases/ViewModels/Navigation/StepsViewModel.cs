using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class StepsViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "Steps";

    public IScreen HostScreen { get; }

    public string UrlPathSegment { get; } = ID;
    
    public StepsViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}