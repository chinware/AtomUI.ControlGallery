using AtomUI.Controls;
using AtomUIGallery.ShowCases.ViewModels;
using Avalonia.Interactivity;
using Avalonia.ReactiveUI;
using ReactiveUI;

namespace AtomUIGallery.ShowCases.Views;

public partial class TabControlShowCase : ReactiveUserControl<TabControlShowCaseViewModel>
{
    public TabControlShowCase()
    {
        this.WhenActivated(disposables =>
        {
            if (DataContext is TabControlShowCaseViewModel viewModel)
            {
                PositionTabStripOptionGroup.OptionCheckedChanged     += viewModel.HandleTabStripPlacementOptionCheckedChanged;
                PositionCardTabStripOptionGroup.OptionCheckedChanged += viewModel.HandleCardTabStripPlacementOptionCheckedChanged;
                SizeTypeTabStripOptionGroup.OptionCheckedChanged     += viewModel.HandleTabStripSizeTypeOptionCheckedChanged;
                AddTabDemoStrip.AddTabRequest                        += HandleTabStripAddTabRequest;

                PositionTabControlOptionGroup.OptionCheckedChanged     += viewModel.HandleTabControlPlacementOptionCheckedChanged;
                PositionCardTabControlOptionGroup.OptionCheckedChanged += viewModel.HandleCardTabControlPlacementOptionCheckedChanged;
                SizeTypeTabControlOptionGroup.OptionCheckedChanged     += viewModel.HandleTabControlSizeTypeOptionCheckedChanged;
                AddTabDemoTabControl.AddTabRequest                     += HandleTabControlAddTabRequest;
            }
        });
        InitializeComponent();
    }
    
    private void HandleTabStripAddTabRequest(object? sender, RoutedEventArgs args)
    {
        var index = AddTabDemoStrip.ItemCount;
        AddTabDemoStrip.Items.Add(new TabStripItem
        {
            Content    = $"new tab {index}",
            IsClosable = true
        });
    }
    
    private void HandleTabControlAddTabRequest(object? sender, RoutedEventArgs args)
    {
        var index = AddTabDemoTabControl.ItemCount;
        AddTabDemoTabControl.Items.Add(new TabItem
        {
            Header     = $"new tab {index}",
            Content    = $"new tab content {index}",
            IsClosable = true
        });
    }
}