using AtomUI;
using AtomUI.Controls;
using AtomUIGallery.ShowCases.ViewModels;
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
        PresetSizeDrawer.DialogSizeType = SizeType.Large;
        PresetSizeDrawer.IsOpen         = true;
    }

    private void HandleOpenDefaultSizeDrawer(object sender, RoutedEventArgs e)
    {
        PresetSizeDrawer.DialogSizeType = SizeType.Small;
        PresetSizeDrawer.IsOpen         = true;
    }

    private void HandleOpenMultilevelLevelTwoDrawer(object sender, RoutedEventArgs e)
    {
        MultiLevelDrawerLevelTwo.IsOpen = true;
    }
}