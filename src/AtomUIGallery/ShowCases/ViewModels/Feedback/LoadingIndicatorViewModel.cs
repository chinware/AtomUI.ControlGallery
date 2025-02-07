using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class LoadingIndicatorViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "LoadingIndicatorShowCase";
    
    public IScreen HostScreen { get; }
    
    public string UrlPathSegment { get; } = ID;
    
    private bool _isLoadingSwitchChecked;

    public bool IsLoadingSwitchChecked
    {
        get => _isLoadingSwitchChecked;
        set => this.RaiseAndSetIfChanged(ref _isLoadingSwitchChecked, value);
    }

    public LoadingIndicatorViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}