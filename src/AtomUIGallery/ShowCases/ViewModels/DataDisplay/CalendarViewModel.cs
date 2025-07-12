using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class CalendarViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "CalendarShowCase";

    public IScreen HostScreen { get; }

    public string UrlPathSegment { get; } = ID;

    public CalendarViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}