using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class DataGridViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "DataGridShowCase";
    
    public IScreen HostScreen { get; }
    
    public string UrlPathSegment { get; } = ID;

    public DataGridViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}