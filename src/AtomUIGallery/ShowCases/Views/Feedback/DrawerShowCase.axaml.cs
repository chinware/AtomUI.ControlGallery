using AtomUI.Controls;
using AtomUIGallery.ShowCases.ViewModels;
using Avalonia;
using Avalonia.Interactivity;
using Avalonia.ReactiveUI;
using ReactiveUI;

namespace AtomUIGallery.ShowCases.Views;

public partial class DrawerShowCase : ReactiveUserControl<DrawerShowCaseViewModel>
{
    public DrawerShowCase()
    {
        this.WhenActivated(disposables => { });
        InitializeComponent();
    }
    
    private void HandleButtonClick(object? sender, RoutedEventArgs e)
    {
        if (sender is not Button button)
        {
            return;
        }

        if (Drawer.GetDrawer(button) is not { } drawer)
        {
            return;
        }

        drawer.IsOpen = false;
    }

    private void HandleButtonOpenOnCurrentParentOnClick(object? sender, RoutedEventArgs e)
    {
        Drawer1.OpenOn = Drawer1.OpenOn?.Parent as Visual;
    }
}