using AtomUIGallery.ShowCases.ViewModels;
using Avalonia.ReactiveUI;
using ReactiveUI;

namespace AtomUIGallery.ShowCases.Views;

public partial class SegmentedShowCase : ReactiveUserControl<SegmentedShowCaseViewModel>
{
    public SegmentedShowCase()
    {
        this.WhenActivated(disposables => { });
        InitializeComponent();
    }
}