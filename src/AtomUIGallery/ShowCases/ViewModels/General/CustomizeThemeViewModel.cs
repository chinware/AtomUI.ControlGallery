using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class CustomizeThemeViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "CustomizeTheme";

    public IScreen HostScreen { get; }

    public string UrlPathSegment { get; } = ID;

    public CustomizeThemeViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}