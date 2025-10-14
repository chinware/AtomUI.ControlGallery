using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class SpinViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "Spin";
    
    public IScreen HostScreen { get; }
    
    public string UrlPathSegment { get; } = ID;
    
    private bool _isLoadingSwitchChecked;

    public bool IsLoadingSwitchChecked
    {
        get => _isLoadingSwitchChecked;
        set => this.RaiseAndSetIfChanged(ref _isLoadingSwitchChecked, value);
    }

    public SpinViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}