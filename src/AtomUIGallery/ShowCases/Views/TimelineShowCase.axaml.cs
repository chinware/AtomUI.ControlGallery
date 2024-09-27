using AtomUIGallery.ShowCases.ViewModels;
using Avalonia.ReactiveUI;
using ReactiveUI;

namespace AtomUIGallery.ShowCases.Views;

public partial class TimelineShowCase : ReactiveUserControl<TimelineShowCaseViewModel>
{
    public TimelineShowCase()
    {
        this.WhenActivated(disposables => { });
        InitializeComponent();
    }
}