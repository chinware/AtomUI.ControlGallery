using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class LoadingIndicatorShowCaseViewModel : ReactiveObject, IRoutableViewModel
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

    public LoadingIndicatorShowCaseViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}