using AtomUIGallery.ShowCases.ViewModels;
using Avalonia.ReactiveUI;
using ReactiveUI;

namespace AtomUIGallery.ShowCases.Views;

public partial class ExpanderShowCase : ReactiveUserControl<ExpanderShowCaseViewModel>
{
    public ExpanderShowCase()
    {
        this.WhenActivated(disposables => { });
        InitializeComponent();
    }
}