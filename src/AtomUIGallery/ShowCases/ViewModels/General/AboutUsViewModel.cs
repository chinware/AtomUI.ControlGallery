using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class AboutUsViewModel : ReactiveObject, IRoutableViewModel, IActivatableViewModel
{
    public const string ID = "AboutUsShowCase";

    public IScreen HostScreen { get; }
    public ViewModelActivator Activator { get; }

    public string UrlPathSegment { get; } = ID;
    

    public AboutUsViewModel(IScreen screen)
    {
        Activator  = new ViewModelActivator();
        HostScreen = screen;
    }
    
}