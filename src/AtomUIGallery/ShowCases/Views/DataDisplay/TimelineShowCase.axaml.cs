using AtomUIGallery.ShowCases.ViewModels;
using Avalonia.ReactiveUI;
using ReactiveUI;
using AtomUI.Controls;
using RadioButton = Avalonia.Controls.RadioButton;

namespace AtomUIGallery.ShowCases.Views;

public partial class TimelineShowCase : ReactiveUserControl<TimelineShowCaseViewModel>
{
    public TimelineShowCase()
    {
        this.WhenActivated(disposables => { });
        InitializeComponent();
        
        ModeLeft.IsCheckedChanged += ModeChecked;

        ModeRight.IsCheckedChanged += ModeChecked;

        ModeAlternate.IsCheckedChanged += ModeChecked;
        
        ReverseButton.Click += ReverseButtonClick;
    }
    
    private void ReverseButtonClick(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        ReverseTimeline.Reverse = !ReverseTimeline.Reverse;
    }
    
    private void ModeChecked(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        if (sender is RadioButton radioButton)
        {
            if (radioButton.Content?.ToString() == "Left")
            {
                LabelTimeline.Mode = TimeLineMode.Left;
            }
            else if (radioButton.Content?.ToString() == "Right")
            {
                LabelTimeline.Mode = TimeLineMode.Right;
            }
            else if (radioButton.Content?.ToString() == "Alternate")
            {
                LabelTimeline.Mode = TimeLineMode.Alternate;
            }
        }
    }

}