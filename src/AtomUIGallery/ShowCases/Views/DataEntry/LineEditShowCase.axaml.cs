using AtomUIGallery.ShowCases.ViewModels;
using Avalonia.ReactiveUI;
using ReactiveUI;

namespace AtomUIGallery.ShowCases.Views;

public partial class LineEditShowCase : ReactiveUserControl<LineEditShowCaseViewModel>
{
    public LineEditShowCase()
    {
        this.WhenActivated(disposables => { });
        InitializeComponent();
    }
}