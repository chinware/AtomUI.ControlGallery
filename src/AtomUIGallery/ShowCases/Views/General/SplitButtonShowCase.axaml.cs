using AtomUIGallery.ShowCases.ViewModels;
using Avalonia.ReactiveUI;
using ReactiveUI;

namespace AtomUIGallery.ShowCases.Views;

public partial class SplitButtonShowCase : ReactiveUserControl<SplitButtonShowCaseViewModel>
{
    public SplitButtonShowCase()
    {
        this.WhenActivated(disposables => { });
        InitializeComponent();
    }
}