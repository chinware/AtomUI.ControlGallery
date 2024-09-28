using AtomUIGallery.ShowCases.ViewModels;
using Avalonia.Controls;
using Avalonia.ReactiveUI;
using ReactiveUI;
using Button = AtomUI.Controls.Button;
using ToggleSwitch = AtomUI.Controls.ToggleSwitch;

namespace AtomUIGallery.ShowCases.Views;

public partial class ToggleSwitchShowCase : ReactiveUserControl<ToggleSwitchShowCaseViewModel>
{
    public ToggleSwitchShowCase()
    {
        this.WhenActivated(disposables => { });
        InitializeComponent();
    }
    
    public static void ToggleDisabledStatus(object arg)
    {
        var switchBtn = (arg as ToggleSwitch)!;
        switchBtn.IsEnabled = !switchBtn.IsEnabled;
    }

    public static void ToggleLoadingStatus(object arg)
    {
        var btn                 = (arg as Button)!;
        var stackPanel          = btn.Parent as StackPanel;
        var toggleSwitchDefault = stackPanel?.Children[0] as ToggleSwitch;
        var toggleSwitchSmall   = stackPanel?.Children[1] as ToggleSwitch;
        if (toggleSwitchDefault is not null)
        {
            toggleSwitchDefault.IsLoading = !toggleSwitchDefault.IsLoading;
        }

        if (toggleSwitchSmall is not null)
        {
            toggleSwitchSmall.IsLoading = !toggleSwitchSmall.IsLoading;
        }
    }
}