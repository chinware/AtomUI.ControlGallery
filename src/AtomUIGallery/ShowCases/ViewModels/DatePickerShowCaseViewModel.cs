using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class DatePickerShowCaseViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "DatePickerShowCase";
    
    public IScreen HostScreen { get; }
    
    public string UrlPathSegment { get; } = ID;

    public DatePickerShowCaseViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}