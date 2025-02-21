using AtomUI;
using AtomUI.Controls;
using AtomUIGallery.ShowCases.ViewModels;
using Avalonia;
using Avalonia.Data.Converters;
using Avalonia.Interactivity;
using Avalonia.ReactiveUI;
using ReactiveUI;

namespace AtomUIGallery.ShowCases.Views;

public partial class DrawerShowCase : ReactiveUserControl<DrawerViewModel>
{
    public static readonly IValueConverter PlacementTextConverter =
        new FuncValueConverter<object?, object?>(x =>
        {
            if (x is int intValue)
            {
                var placement = (DrawerPlacement)intValue;
                return placement.ToString();
            }

            return x;
        });
    public DrawerShowCase()
    {
        this.WhenActivated(disposables =>
        {
            if (DataContext is DrawerViewModel viewModel)
            {
            }
        });
        InitializeComponent();
    }

    private void HandleOpenLargeSizeDrawer(object sender, RoutedEventArgs e)
    {
        // PresetSizeDrawer.SizeType = SizeType.Large;
        // PresetSizeDrawer.IsOpen = true;
    }
    
    private void HandleOpenDefaultSizeDrawer(object sender, RoutedEventArgs e)
    {
        // PresetSizeDrawer.SizeType = SizeType.Small;
        // PresetSizeDrawer.IsOpen   = true;
    }
    
    private void HandleOpenMultilevelLevelTwoDrawer(object sender, RoutedEventArgs e)
    {
        MultiLevelDrawerLevelTwo.IsOpen = true;
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
        // Drawer1.OpenOn = Drawer1.OpenOn?.Parent as Visual;
    }
}