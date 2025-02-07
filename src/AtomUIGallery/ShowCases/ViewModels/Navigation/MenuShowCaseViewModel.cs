using AtomUI.Controls;
using Avalonia.Interactivity;
using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class MenuShowCaseViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "MenuShowCase";

    public IScreen HostScreen { get; }

    public string UrlPathSegment { get; } = ID;

    private bool _isDark;

    public bool IsDark
    {
        get => _isDark;
        set => this.RaiseAndSetIfChanged(ref _isDark, value);
    }

    private NavMenuMode _mode;

    public NavMenuMode Mode
    {
        get => _mode;
        set => this.RaiseAndSetIfChanged(ref _mode, value);
    }

    public MenuShowCaseViewModel(IScreen screen)
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