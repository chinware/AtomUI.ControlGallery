using AtomUI.Controls;
using AtomUI.Controls.Primitives;
using Avalonia.Interactivity;
using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class MenuViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "Menu";

    public IScreen HostScreen { get; }

    public string UrlPathSegment { get; } = ID;

    private bool _isDark;

    public bool IsDark
    {
        get => _isDark;
        set => this.RaiseAndSetIfChanged(ref _isDark, value);
    }

    private NavMenuMode _mode = NavMenuMode.Inline;

    public NavMenuMode Mode
    {
        get => _mode;
        set => this.RaiseAndSetIfChanged(ref _mode, value);
    }
    
    private IList<TreeNodePath>? _defaultOpenPaths;

    public IList<TreeNodePath>? DefaultOpenPaths
    {
        get => _defaultOpenPaths;
        set => this.RaiseAndSetIfChanged(ref _defaultOpenPaths, value);
    }

    private TreeNodePath? _defaultSelectedPath;
    
    public TreeNodePath? DefaultSelectedPath
    {
        get => _defaultSelectedPath;
        set => this.RaiseAndSetIfChanged(ref _defaultSelectedPath, value);
    }

    private List<ITreeNode> _navMenuItems = [];
    
    public List<ITreeNode> NavMenuItems
    {
        get => _navMenuItems;
        set => this.RaiseAndSetIfChanged(ref _navMenuItems, value);
    }

    public MenuViewModel(IScreen screen)
    {
        HostScreen = screen;
    }

    public void HandleChangeModeCheckChanged(object? sender, RoutedEventArgs? args)
    {
        if (sender is ToggleSwitch changeModeSwitch)
        {
            if (changeModeSwitch.IsChecked.HasValue)
            {
                if (changeModeSwitch.IsChecked.Value)
                {
                    Mode = NavMenuMode.Vertical;
                }
                else
                {
                    Mode = NavMenuMode.Inline;
                }
            }
            else
            {
                Mode = NavMenuMode.Inline;
            }
        }
    }

    public void HandleChangeStyleCheckChanged(object? sender, RoutedEventArgs? args)
    {
        if (sender is ToggleSwitch changeModeSwitch)
        {
            if (changeModeSwitch.IsChecked.HasValue)
            {
                IsDark = changeModeSwitch.IsChecked.Value;
            }
            else
            {
                IsDark = false;
            }
        }
    }
}