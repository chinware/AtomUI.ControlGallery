using AtomUI.Controls;
using AtomUIGallery.ShowCases.ViewModels;
using Avalonia.Interactivity;
using Avalonia.ReactiveUI;
using ReactiveUI;
using TabItem = AtomUI.Controls.TabItem;

namespace AtomUIGallery.ShowCases.Views;

public partial class TabControlShowCase : ReactiveUserControl<TabControlViewModel>
{
    public TabControlShowCase()
    {
        this.WhenActivated(disposables =>
        {
            if (DataContext is TabControlViewModel viewModel)
            {
                PositionTabStripOptionGroup.OptionCheckedChanged     += viewModel.HandleTabStripPlacementOptionCheckedChanged;
                PositionCardTabStripOptionGroup.OptionCheckedChanged += viewModel.HandleCardTabStripPlacementOptionCheckedChanged;
                SizeTypeTabStripOptionGroup.OptionCheckedChanged     += viewModel.HandleTabStripSizeTypeOptionCheckedChanged;
                AddTabDemoStrip.AddTabRequest                        += HandleTabStripAddTabRequest;
                
                PositionTabControlOptionGroup.OptionCheckedChanged     += viewModel.HandleTabControlPlacementOptionCheckedChanged;
                PositionCardTabControlOptionGroup.OptionCheckedChanged += viewModel.HandleCardTabControlPlacementOptionCheckedChanged;
                SizeTypeTabControlOptionGroup.OptionCheckedChanged     += viewModel.HandleTabControlSizeTypeOptionCheckedChanged;
                AddTabDemoTabControl.AddTabRequest                     += HandleTabControlAddTabRequest;
                
                viewModel.TabItemDataSource.Add(new TabItemData()
                {
                    Header = "Tab 1",
                    Content = "Tab Content 1"
                });
                viewModel.TabItemDataSource.Add(new TabItemData()
                {
                    Header  = "Tab 2",
                    Content = "Tab Content 2"
                });
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