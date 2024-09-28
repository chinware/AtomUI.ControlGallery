using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class TreeViewShowCaseViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "TreeViewShowCase";
    
    public IScreen HostScreen { get; }
    
    public string UrlPathSegment { get; } = ID;
    
    private bool _showLineSwitchChecked = true;

    public bool ShowLineSwitchChecked
    {
        get => _showLineSwitchChecked;
        set => this.RaiseAndSetIfChanged(ref _showLineSwitchChecked, value);
    }
    
    private bool _showIconSwitchChecked;

    public bool ShowIconSwitchChecked
    {
        get => _showIconSwitchChecked;
        set => this.RaiseAndSetIfChanged(ref _showIconSwitchChecked, value);
    }

    private bool _showLeafSwitcherSwitchChecked;

    public bool ShowLeafSwitcherSwitchChecked
    {
        get => _showLeafSwitcherSwitchChecked;
        set => this.RaiseAndSetIfChanged(ref _showLeafSwitcherSwitchChecked, value);
    }

    public TreeViewShowCaseViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}