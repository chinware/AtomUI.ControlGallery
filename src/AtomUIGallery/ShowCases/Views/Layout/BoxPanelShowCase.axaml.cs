using AtomUI.Controls;
using AtomUIGallery.ShowCases.ViewModels;
using Avalonia.Controls.Primitives;
using Avalonia.Interactivity;
using Avalonia.Layout;
using Avalonia.ReactiveUI;
using ReactiveUI;

namespace AtomUIGallery.ShowCases.Views;

public partial class BoxPanelShowCase : ReactiveUserControl<BoxPanelViewModel>
{
    public BoxPanelShowCase()
    {
        this.WhenActivated(disposables => { });
        InitializeComponent();
        
        Vertical.IsCheckedChanged += HandleModeChecked;

        Horizontal.IsCheckedChanged += HandleModeChecked;
        
        Vertical1.IsCheckedChanged += HandleMode1Checked;

        Horizontal1.IsCheckedChanged += HandleMode1Checked;
    }
    
    
    private void HandleMode1Checked(object? sender, RoutedEventArgs e)
    {
        if (sender is RadioButton button)
        {
            if (button.Content?.ToString() == "Vertical")
            {
                FlexBoxPanel.Orientation = Orientation.Vertical;
            }
            else if (button.Content?.ToString() == "Horizontal")
            {
                FlexBoxPanel.Orientation = Orientation.Horizontal;
            }
        }
    }
    
    private void HandleModeChecked(object? sender, RoutedEventArgs e)
    {
        if (sender is RadioButton button)
        {
            if (button.Content?.ToString() == "Vertical")
            {
                BasicBoxPanel.Orientation = Orientation.Vertical;
            }
            else if (button.Content?.ToString() == "Horizontal")
            {
                BasicBoxPanel.Orientation = Orientation.Horizontal;
            }
        }
    }

    private void HandleSpaceSliderValueChanged(object? sender, RangeBaseValueChangedEventArgs e)
    {
        ChangeSpaceBoxPanel.Spacing = e.NewValue;
    }

    private void HandleAddSpaceButtonClicked(object? sender, RoutedEventArgs e)
    {
        if (e.Source is Button button && button.Content?.ToString() == "add a space of size 40")
        {
            ChangeSpaceBoxPanel.AddSpacing(40);
            AddSpaceButton.Content = "remove the space of size 40";
        }
        else
        {
            ChangeSpaceBoxPanel.Children.Remove(ChangeSpaceBoxPanel.Children[4]);
            AddSpaceButton.Content = "add a space of size 40";
        }
    }

    private void HandleChangFlexButtonClicked(object? sender, RoutedEventArgs e)
    {
            BoxPanel.SetFlex(ChangeSpaceBoxPanel.Children[3], BoxPanel.GetFlex(ChangeSpaceBoxPanel.Children[3]) == 1 ? 2 : 1);
    }

    private void HandleAddFlexButtonClicked(object? sender, RoutedEventArgs e)
    {
        if (e.Source is Button button && button.Content?.ToString() == "add a placeholder flex")
        {
            AddPlaceholderBoxPanel.AddFlex(1);
            AddFlexButton.Content = "remove the placeholder flex";
        }
        else
        {
            AddPlaceholderBoxPanel.Children.Remove(AddPlaceholderBoxPanel.Children[2]);
            AddFlexButton.Content = "add a placeholder flex";
        }
    }
}